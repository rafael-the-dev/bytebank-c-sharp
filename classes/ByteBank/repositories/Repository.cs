using System;
using System.IO;

namespace ByteBank.Repositories {
    public class Repository {
        public static string Path = @"C:\salc\C#\classes\ByteBank\data.txt";

        public static string[] GetAllLine()
        {
            string[] lines = File.ReadAllLines(Path);

            return lines;
        }

        public static void Delete(string id)
        {
            string[] lines = GetAllLine();
            string result = "";

            foreach (string line in lines)
            {
                string[] chunks = line.Split(',');

                if (chunks[0] != id)
                {
                    result += line + Environment.NewLine;
                }
            }

            File.WriteAllText(Path, result);
        }
    }
}