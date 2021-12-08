using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SystemIO
{
    public class StreamReaderWriter
    {
        public void WriteUsingStreamReader()
        {
            string path = @"F:\IO\FileIOOperations\SystemIO\SystemIO\Example.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine(" Hello World - .NET is Awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.WriteLine();
        }
        public void ReadFromStreamReader()
        {
            string path = @"F:\IO\FileIOOperations\SystemIO\SystemIO\Example.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine();
        }
    }
}
