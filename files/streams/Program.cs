using System;
using System.IO;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\salc\C#\files\streams\file1.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
            }
        }
    }
}