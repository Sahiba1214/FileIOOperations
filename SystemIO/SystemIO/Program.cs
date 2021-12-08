using System;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            op.FileExists();
            op.ReadAllLines();
            op.ReadAllText();
            op.FileCopy();
            //op.DeleteFile();
            StreamReaderWriter stream = new StreamReaderWriter();
            stream.ReadFromStreamReader();
            stream.WriteUsingStreamReader();
        }
    }
}
