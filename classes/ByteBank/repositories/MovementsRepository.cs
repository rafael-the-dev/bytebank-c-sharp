using System;
using System.IO;
using System.Text;

using ByteBank.Entities;

//Id,AccountId,amount,type,date

namespace ByteBank.Repositories {
    class MovementsRepository {
        private static string path = @"C:\salc\C#\classes\ByteBank\movements.txt";

        private static string[] GetAllLine()
        {
            string[] lines = File.ReadAllLines(path);

            return lines;
        }

        public static void Save(string accountId, Movement movement) {
            string[] lines = GetAllLine();
            int index = lines.Length + 1;

            string line = index
                + "," + accountId
                + "," + movement.Amount
                + "," + movement.Type
                + "," + movement.Date;

            File.AppendAllText(path, line);
        }

        public static void Delete(string id) {
            string[] lines = GetAllLine();
            string result = "";

            foreach (string line in lines) {
                string[] chunks = line.Split(',');
                if (chunks[0] != id) result += line + Environment.NewLine;
            }

            File.WriteAllText(path, result);
        }
    }
}