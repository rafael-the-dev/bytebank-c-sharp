using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

using ByteBank.Entities;

namespace ByteBank.Repositories
{
    class AccountRepository
    {
        private static string path = @"C:\salc\C#\classes\ByteBank\data.txt";

        private static string[] GetAllLine()
        {
            string[] lines = File.ReadAllLines(path);

            return lines;
        }

        public static List<Account> GetMany()
        {
            string[] lines = GetAllLine();

            List<Account> list = new List<Account>();

            foreach (string line in lines)
            {
                string[] chunks = line.Split(',');

                Account account = new Account(
                    new Client(chunks[1]),
                    chunks[0],
                    double.Parse(chunks[2])
                );

                list.Add(account);
            }

            return list;
        }


        public static void Save(Account account) {
            string line = account.Id + "," + account.Holder.Name + "," + account.Amount + Environment.NewLine;

            File.AppendAllText(path, line);
        }

        public static void UpdateBalance(string id, double amount) {
            string[] lines = GetAllLine();
            string result = "";

            foreach(string line in lines) {
                string[] chunks = line.Split(',');

                if (chunks[0] == id)
                {
                    result += chunks[0] + "," + chunks[1] + "," + amount + Environment.NewLine;
                } else
                {
                    result += line + Environment.NewLine;
                }
            }

            File.WriteAllText(path, result);
        }

        public static void Delete(string id)
        {
            string[] lines = GetAllLine();
            string result = "";

            foreach (string line in lines)
            {
                string[] chunks = line.Split(',');

                if (chunks[0] != id) {
                    result += line + Environment.NewLine;
                }
            }

            File.WriteAllText(path, result);
        }
    }
}