using System.ComponentModel.Design;

namespace Database_B_tree{
    public class Database{
        public int NumberRecords;
        int FurthestIndex;
        Tree tree;
        string StorageFile;
        string InfoFileAddress;
        public Database(string infoFileAddress){
            InfoFileAddress=infoFileAddress;
            string[] contents=File.ReadAllText(InfoFileAddress).Split(" ");
            StorageFile=contents[0];
            tree=new Tree(contents[1]);
            if(!File.Exists(StorageFile)){
                Initialize();
            }
            using (BinaryReader sk = new BinaryReader(File.Open(StorageFile, FileMode.Open)))
            {
                sk.BaseStream.Seek(0, SeekOrigin.Begin);
                NumberRecords = BitConverter.ToInt32(sk.ReadBytes(sizeof(Int32)));
            }
        }
        public Database(string Head, string Storage){
            this.tree = new Tree(Head);
            this.StorageFile = Storage;
            if(!File.Exists(StorageFile)){
                Initialize();
            }
            using (BinaryReader sk = new BinaryReader(File.Open(StorageFile, FileMode.Open)))
            {
                sk.BaseStream.Seek(0, SeekOrigin.Begin);
                NumberRecords = BitConverter.ToInt32(sk.ReadBytes(sizeof(Int32)));
            }
            
        }
        public void Initialize(){
            if(!File.Exists(StorageFile)){
                File.Create(StorageFile).Close();
                
            }
            BinaryWriter binaryWriter= new BinaryWriter(new FileStream(StorageFile, FileMode.Truncate));
            NumberRecords=0;
            binaryWriter.Write(BitConverter.GetBytes(NumberRecords));
            binaryWriter.Close();
        }
        public void SaveInfo(){
            File.WriteAllText(InfoFileAddress, StorageFile+" "+tree.Head.NodeFileName);
        }
        public void AddRecord(RecordDatabase record){
            
            using (FileStream sk = new FileStream(StorageFile, FileMode.Open, FileAccess.Write))
            {
                sk.Seek(/*sizeof(Int32)+NumberRecords*RecordDatabase.ByteSize, */0,SeekOrigin.End);
                tree.AddNewElement(new Record(record.Index, NumberRecords));
                sk.Write(record.ToBytes());
                NumberRecords++;
                sk.Seek(0, SeekOrigin.Begin);
                sk.Write(BitConverter.GetBytes(NumberRecords));
            }
            SaveInfo();    
        }
        public void DeleteRecord(string Index){
            tree.Delete(Index);
        }
        public void FillDatabase(int NumberRecords){
            for(int i=0;i<NumberRecords;i++){
                RecordDatabase record;
                do{
                    record=CreateRandomRecord();
                }while(GetRecord(record.Index)!=null);
                AddRecord(record);
                Console.WriteLine($"{i} elements added");
            }
        }
        public void FillDatabaseBrainrot(int NumberRecords)
        {
            for (int i = 0; i < NumberRecords; i++)
            {
                RecordDatabase record;
                do
                {
                    record = new RecordDatabase(RandomString(RecordDatabase.IndexByteSize), Brainrot.GenerateBrainrotString());
                    
                } while (GetRecord(record.Index) != null);
                AddRecord(record);
                Console.WriteLine($"{i} elements added");
            }
        }
        public RecordDatabase GetRecord(string index){
            Record TreeRecord=tree.Find(index);
            if(TreeRecord==null){return null;}
            return GetRecord(TreeRecord.Place);
        } 
        public RecordDatabase GetRecord(int place){
            using (FileStream reader=new FileStream(StorageFile,FileMode.Open,FileAccess.Read)){
                reader.Seek(sizeof(Int32)+place*RecordDatabase.ByteSize, SeekOrigin.Current);
                byte[] buffer=new byte[RecordDatabase.ByteSize];
                reader.Read(buffer, 0, RecordDatabase.ByteSize);
                RecordDatabase ToReturn= new RecordDatabase(buffer);
                ToReturn.place=place;
                return ToReturn;
            }
        }
        public RecordDatabase CreateRandomRecord(){
            return new RecordDatabase(RandomString(20), RandomString(100));
        }
        public string RandomString(int length){
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string result = "";
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                result+=chars[random.Next(chars.Length)];
            }

            return result;
        }
    }
}