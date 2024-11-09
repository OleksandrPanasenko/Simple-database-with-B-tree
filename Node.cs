using System.DirectoryServices;

namespace Database_B_tree
{
    public class Node{
        public Node FatherNode;
        public string NodeFileName;
        public List<Record> records;
        public List<string> ChildrenFileNames;
        public bool IsLeaf{
            get { return !(ChildrenFileNames.Count>0); }
        }
        public Node(){
            records = new List<Record>();
            ChildrenFileNames = new List<string>();
        }
        public Node(Node fatherNode):this(){
            FatherNode=fatherNode;
        }
        public Node(string fileAddress): this(){
            
            NodeFileName=fileAddress;
            if(File.Exists(fileAddress)){
                StreamReader reader=new StreamReader(fileAddress);
                string[] fileText=reader.ReadToEnd().Split("\n");
                int Size=int.Parse(fileText[0]);
                for(int i=1;i<Size+1;i++){
                    string[] recordText=fileText[i].Split(" ");
                    Record newRecord=new Record(recordText[0], int.Parse(recordText[1]));
                    records.Add(newRecord);
                }
                for(int i=Size+1; i<Size*2+2&&i<fileText.Length; i++){ // may add "leaf" variable for perfomance'
                    if(fileText[i]!=""){
                        ChildrenFileNames.Add(fileText[i]);
                    }
                }
                reader.Close();
            }
            else{
                File.Create(fileAddress).Close();
            }
        }
        public Node(Node fatherNode,string fileAddress):this(fileAddress){
            FatherNode=fatherNode;
        }
        public void AddRecord(Record record){
            if(records.Count==0) {
                records.Add(record);
                UpdateFile();
                return;
                }
            if(record.Compare(records[0])<0) {
                records.Insert(0, record);
                UpdateFile();
                return;
            }
            if(record.Compare(records[records.Count-1])>0){ 
                records.Add(record);
                UpdateFile();
                return;
            }
            for(int i=0;i<records.Count-1;i++){
                if (record.Compare(records[i])>0&&record.Compare(records[i+1])<0){
                    records.Insert(i, record);
                    UpdateFile();
                    return;
                }
            }
        }
        public string CreateChildNode(){
            string[] dividedPath=NodeFileName.Split('.');
            string filePath="";
            for(int i=0;i<dividedPath.Length-1;i++){
                filePath+=dividedPath[i]+".";
            }
            string toReturn;
            int j=0;
            do{
                toReturn=filePath+$"_{j}.txt";
                j++;
            }while(File.Exists(toReturn));
            return toReturn;
        }
        public string CreateFatherNode(){
            if(FatherNode is not null) throw new Exception("Bro has father already 💀");
            string[] dividedPath=NodeFileName.Split('.');
            string filePath="";
            for(int i=0;i<dividedPath.Length-1;i++){
                filePath+=dividedPath[i]+".";
            }
            return filePath+$"_Head.txt";;
        }
        public void UpdateFile(){
            string toFile=records.Count.ToString()+"\n";
            foreach(Record record in records){
                toFile+=record.Index+" "+record.Place.ToString()+"\n";
            }
            foreach(string child in ChildrenFileNames){
                toFile+=child+"\n";
            }
            StreamWriter fileWriter=new StreamWriter(NodeFileName);
            fileWriter.Write(toFile);
            fileWriter.Close();
        }
        public void Delete(){
            File.Delete(NodeFileName);
        }
        public void SplitNode(){
            if(records.Count>4&&records.Count%2==1){
                Node newNode=new Node(FatherNode);
                for(int i=records.Count/2+1;i<records.Count;){
                    newNode.records.Add(records[i]);
                    records.RemoveAt(i);
                    if(!IsLeaf){
                    newNode.ChildrenFileNames.Add(ChildrenFileNames[i]);
                    ChildrenFileNames.RemoveAt(i);
                    }
                }
                if(!IsLeaf){
                    newNode.ChildrenFileNames.Add(ChildrenFileNames[ChildrenFileNames.Count-1]);
                    ChildrenFileNames.RemoveAt(ChildrenFileNames.Count-1);
                }
                Record toReturn=records[records.Count-1];
                records.RemoveAt(records.Count-1);

                newNode.NodeFileName=CreateChildNode();
                UpdateFile();
                newNode.UpdateFile();
                FatherNode.ChildrenFileNames.Insert(FatherNode.ChildrenFileNames.IndexOf(NodeFileName)+1,newNode.NodeFileName);
                FatherNode.AddRecord(toReturn);
                FatherNode.UpdateFile();
                return;
            }
            throw new Exception("Attempting to split even node");
        }
        public Node RightNeighbour(){
            if(FatherNode is not null){
                int position=FatherNode.ChildrenFileNames.IndexOf(NodeFileName);
                if(position<FatherNode.ChildrenFileNames.Count-1){
                    return new Node(FatherNode.ChildrenFileNames[position+1]);
                }

            }
            return null;
        }
        public Node LeftNeighbour(){
            if(FatherNode is not null){
                int position=FatherNode.ChildrenFileNames.IndexOf(NodeFileName);
                if(position>0){
                    return new Node(FatherNode.ChildrenFileNames[position-1]);
                }

            }
            return null;
        }
        public Node MergeWithLeft(int tValue){
            if(FatherNode is not null){
                Node rightBrother, leftBrother;
                rightBrother=this;
                if(FatherNode.ChildrenFileNames[0]==NodeFileName)
                {
                    leftBrother=this;
                    rightBrother=RightNeighbour();
                }
                else{
                    leftBrother=LeftNeighbour();
                }
                if(leftBrother.records.Count+rightBrother.records.Count+1<tValue){
                    int place=FatherNode.ChildrenFileNames.IndexOf(leftBrother.NodeFileName);
                    leftBrother.records.Add(FatherNode.records[place]);
                    FatherNode.records.RemoveAt(place);
                    FatherNode.ChildrenFileNames.RemoveAt(place+1);
                    for(int i=0;i<rightBrother.records.Count;i++) leftBrother.records.Add(rightBrother.records[i]);
                    for(int i=0;i<rightBrother.ChildrenFileNames.Count;i++) leftBrother.ChildrenFileNames.Add(rightBrother.ChildrenFileNames[i]);
                    FatherNode.UpdateFile();
                    leftBrother.UpdateFile();
                    rightBrother.Delete();
                }
                return leftBrother;
            }
            else return null;
        }

    }
}

/*
3
Sigma 4
Skibidi 16
SLAY_QUEEN 12
10_1.txt
10_2.txt
10_3.txt
10_4.txt
*/