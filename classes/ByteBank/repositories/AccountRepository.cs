using System;
using System.IO;
using System.Collections.Generic;

using ByteBank.Entities;

namespace ByteBank.Repositories
{
    class AccountRepository
    {
        private static string path = @"C:\salc\C#\classes\ByteBank\data.txt";

        public static List<Account> getMany()
        {
            string[] lines = File.ReadAllLines(path);

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
    }
}