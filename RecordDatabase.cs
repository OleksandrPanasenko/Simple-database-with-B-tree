using System.ComponentModel;
using System.Text;

namespace Database_B_tree{
    public class RecordDatabase{
        public RecordDatabase(string index, string text){
            Index = index;
            Text=text;
        }
        public RecordDatabase(byte[] data){
            byte[] buffer1=new byte[IndexByteSize];
            Array.Copy(data, buffer1, IndexByteSize);
            byte[] buffer2=new byte[TextByteSize];
            Array.Copy(data, IndexByteSize, buffer2, 0, TextByteSize);
            Index=Encoding.ASCII.GetString(buffer1);
            Text=Encoding.ASCII.GetString(buffer2);
        }
        public static int ByteSize = IndexByteSize+TextByteSize;
        public const int IndexByteSize = 20;
        public const int  TextByteSize = 100;
        public readonly string Index;
        public readonly string Text;
        public int place;//not to record write to file!!!
        
        public byte[] ToBytes(){
            byte[] IndexBytes=Encoding.ASCII.GetBytes(Index);
            byte[] IndexBytesFixed=new byte[IndexByteSize];
            if(IndexBytes.Length>IndexByteSize){
                Array.Copy(IndexBytes, IndexBytesFixed, IndexByteSize);
            }
            else{
                Array.Copy(IndexBytes,IndexBytesFixed, IndexBytes.Length);
            }
            byte[] TextBytes=Encoding.ASCII.GetBytes(Text);
            byte[] TextBytesFixed=new byte[TextByteSize];
            if(TextBytes.Length>TextByteSize){
                Array.Copy(TextBytes,TextBytesFixed, TextByteSize);
            }
            else{
                Array.Copy(TextBytes, TextBytesFixed, TextBytes.Length);
            }
            byte[] ToReturn = new byte[ByteSize];
            Array.Copy(IndexBytesFixed,ToReturn,IndexByteSize);
            Array.Copy(TextBytesFixed, 0, ToReturn, IndexByteSize, TextByteSize);
            return ToReturn;
        }
    }
}