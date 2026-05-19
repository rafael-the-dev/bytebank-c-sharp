using System;
using System.IO;
using System.Text;

using ByteBank.Entities;

//Id,AccountId,amount,type,date

namespace ByteBank.Repositories {
    class MovementsRepository : Repository {
        private static string path = @"C:\salc\C#\classes\ByteBank\movements.txt";

        public static int Save(string accountId, Movement movement) {
            string[] lines = GetAllLine();
            int index = lines.Length + 1;

            string line = index
                + "," + accountId
                + "," + movement.Amount
                + "," + movement.Type
                + "," + movement.Date
                + Environment.NewLine; 

            File.AppendAllText(path, line);

            return index;
        }
    }
}