using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SystemIO
{
    public class Operations
    {
        public void FileExists()
        {
            string path = @"F:\IO\FileIOOperations\SystemIO\SystemIO\Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            Console.WriteLine();
        }
        public void ReadAllLines()
        {
            string path = @"F:\IO\FileIOOperations\SystemIO\SystemIO\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine();
        }
        public void ReadAllText()
        {
            string path = @"F:\IO\FileIOOperations\SystemIO\SystemIO\Example.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.WriteLine();
        }
        public void FileCopy()
        {
            string path = @"F:\IO\FileIOOperations\SystemIO\SystemIO\Example.txt";
            string copyPath = @"F:\IO\FileIOOperations\SystemIO\SystemIO\NewExample.txt";
            File.Copy(path, copyPath);
            Console.WriteLine();
        }
        public void DeleteFile()
        {
            string path = @"F:\IO\FileIOOperations\SystemIO\SystemIO\Example.txt";
            File.Delete(path);
            Console.WriteLine();
        }
    }
}