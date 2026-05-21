using System;
using System.IO;

namespace ByteBank.Repositories {
    public abstract class Repository {
        public abstract string Path { get; }

        public string[] GetAllLine()
        {
            string[] lines = File.ReadAllLines(Path);

            return lines;
        }

        public void Delete(string id)
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