using System.ComponentModel;
using System.Text;

namespace Database_B_tree{
    public class Record{
        public Record(string index, int location){
            Index = index;
            Place=location;
        }
        public readonly string Index;
        public readonly int Place;
        public int Compare(Record two){
            return string.Compare(this.Index, two.Index);
        }
    
        /*public byte[] ToBytes(){
            byte[] IndexBytes=Encoding.UTF8.GetBytes(Index);
            byte[] IndexBytesFixed=new byte[20];
            if(IndexBytes.Length>20){
                Array.Copy(IndexBytes, IndexBytesFixed, 20);
            }
            else{
                Array.Copy(IndexBytesFixed,IndexBytes, IndexBytes.Length);
            }
            byte[] PlaceBytes=BitConverter.GetBytes(Place);
            byte[] ToReturn = new byte[IndexBytesFixed.Length+PlaceBytes.Length];
            Array.Copy(IndexBytesFixed,ToReturn,20);
            Array.Copy(PlaceBytes,ToReturn,PlaceBytes.Length);
            return ToReturn;
        }*/
    }
}