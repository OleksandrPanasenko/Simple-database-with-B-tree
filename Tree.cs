using System.Configuration;
using Database_B_tree;

    public class Tree{
        internal Node Head;
        int Tvalue = 2;
        public Tree(Node head){
            this.Head = head;
        }
        public Tree(string path){
            this.Head = new Node(path);
        }
        public Record Find(string index){
            return FindElement(index, Head);
        }
        Record FindElement(string index, Node current){
            if(current.IsLeaf){
                foreach(Record record in current.records){
                    if(record.Index==index){
                        return record;
                    }
                }
                return null;
                throw new Exception("Element wasn't found");
            }
            else{
                if(string.Compare(index, current.records[current.records.Count-1].Index)>0) {
                    return FindElement(index,new Node(current.ChildrenFileNames[current.ChildrenFileNames.Count-1]));
                }
                for(int i=0;i<current.records.Count;i++){
                    if(string.Compare(current.records[i].Index, index)==0){
                        return current.records[i];
                    }
                    else if(string.Compare(index,current.records[i].Index)<0){
                        return FindElement(index,new Node(current.ChildrenFileNames[i]));
                    }
                }
                throw new Exception("Something went wrong with search");
            }
        }
        Node FindNodeByIndex(string index, Node current){
            if(current.IsLeaf){
                foreach(Record record in current.records){
                    if(record.Index==index){
                        return current;
                    }
                }
                throw new Exception("Element wasn't found");
            }
            else{
                if(string.Compare(index, current.records[current.records.Count-1].Index)>0) {
                    return FindNodeByIndex(index,new Node(current, current.ChildrenFileNames[current.ChildrenFileNames.Count-1]));
                }
                for(int i=0;i<current.records.Count;i++){
                    if(string.Compare(current.records[i].Index, index)==0){
                        return current;
                    }
                    else if(string.Compare(index,current.records[i].Index)<0){
                        return FindNodeByIndex(index,new Node(current,current.ChildrenFileNames[i]));
                    }
                }
                throw new Exception("Something went wrong with search");
            }
        }
        public void AddNewElement(Record record){
            Node current=Head;
            while(current.ChildrenFileNames.Count>0){ // to the end
                if(record.Compare(current.records[0])<0){
                    current=new Node(current, current.ChildrenFileNames[0]);
                    continue;
                }
                else if(record.Compare(current.records[current.records.Count-1])>0){
                    current=new Node(current, current.ChildrenFileNames[current.records.Count]);
                    continue;
                }
                else{
                    for(int i=0;i<current.records.Count-1&&!current.IsLeaf;i++){
                        if(current.records[i].Compare(record)<0&&current.records[i+1].Compare(record)>0){
                            current=new Node(current, current.ChildrenFileNames[i+1]);
                        }
                    }
                    
                }
            }
            current.AddRecord(record);
            //Update?
            while(current.records.Count>2*Tvalue){
                if(current==Head){
                    Node NewHead=new Node(current.CreateFatherNode());
                    Head.FatherNode=NewHead;
                    NewHead.ChildrenFileNames.Add(Head.NodeFileName);
                    Head=NewHead;
                }
                current.SplitNode();
                current=current.FatherNode;
            }
        }
        public void Delete(string index){
            DeleteFrom(FindNodeByIndex(index, Head), index);
        }
        void DeleteFrom(Node node, string index){
            Node location=node;
            if(location.IsLeaf){
                if(location==Head){
                    for(int i=0;i<Head.records.Count;i++){
                        if(string.Compare(index,Head.records[i].Index)==0){
                            Head.records.RemoveAt(i);
                            Head.UpdateFile();
                            return;
                        }
                    };
                }
                else{
                    for(int i=0;i<location.records.Count;i++){
                        if(string.Compare(index,location.records[i].Index)==0){
                            location.records.RemoveAt(i);
                            if(location.records.Count<Tvalue){
                                Node left=location.LeftNeighbour();
                                Node right=location.RightNeighbour();
                                if(left is not null){
                                    if(left.records.Count+location.records.Count+1<=2*Tvalue){
                                        location.MergeWithLeft(Tvalue);//fix to not check twice
                                    }
                                    else{
                                        int recordPlacement=location.FatherNode.ChildrenFileNames.IndexOf(location.NodeFileName)-1;//place within fatherly node
                                        location.AddRecord(location.FatherNode.records[recordPlacement]);
                                        location.FatherNode.records.RemoveAt(recordPlacement);  
                                        location.FatherNode.AddRecord(left.records[left.records.Count-1]);//autosaves
                                        left.records.RemoveAt(left.records.Count-1);
                                        left.UpdateFile();
                                    }
                                }
                                else if(right is not null){
                                    if(right.records.Count+location.records.Count+1<=2*Tvalue){
                                        location.MergeWithLeft(Tvalue);//fix to not check twice
                                    }
                                    else{
                                        location.AddRecord(location.FatherNode.records[0]);
                                        location.FatherNode.records.RemoveAt(0);
                                        location.FatherNode.AddRecord(right.records[0]);
                                        right.records.RemoveAt(0);
                                        right.UpdateFile();
                                    }
                                }
                                else throw new Exception ("It was a lone node after all");
                            }
                            return;
                        }
                    }
                }
            }
            else{
                for(int i=0;i<location.records.Count; i++){
                    if(location.records[i].Index==index){
                        Node right=new Node(location, location.ChildrenFileNames[i+1]);
                        if(right.records.Count>Tvalue){
                            location.records.RemoveAt(i);
                            location.AddRecord(right.records[0]);
                            DeleteFrom(right, right.records[0].Index);
                        }
                        else{
                            Node left=right.LeftNeighbour();
                            location.records.RemoveAt(i);
                            location.AddRecord(left.records[left.records.Count-1]);
                            DeleteFrom(left, left.records[left.records.Count-1].Index);
                            if(left.records.Count<Tvalue){
                                right.MergeWithLeft(Tvalue);
                            }

                        }
                        return;
                    }
                }
            }
        }
    }