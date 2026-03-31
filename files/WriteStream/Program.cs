using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\salc\C#\files\WriteStream\file1.txt";
            string targetPath = @"C:\salc\C#\files\WriteStream\file2.txt";

            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
    }
}