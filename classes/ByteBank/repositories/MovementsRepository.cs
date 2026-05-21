using System;
using System.IO;
using System.Text;

using ByteBank.Entities;

//Id,AccountId,amount,type,date

namespace ByteBank.Repositories {
    class MovementsRepository : Repository {
        public override string Path => @"C:\salc\C#\classes\ByteBank\movements.txt";

        public int Save(string accountId, Movement movement) {
            string[] lines = GetAllLine();
            int index = lines.Length + 1;

            string line = index
                + "," + accountId
                + "," + movement.Amount
                + "," + movement.Type
                + "," + movement.Date
                + Environment.NewLine; 

            File.AppendAllText(Path, line);

            return index;
        }

        // write a function that convert string date time to DateTime
        private DateTime GetDateTime(string value) {
            string[] chunks = value.Split(" ");
            string dateChunk = chunks[0];
            string timeChunk = chunks[1];

            string[] dateChunks = dateChunk.Split("/");
            string[] timeChunks = timeChunk.Split(":");

            return new DateTime(
                int.Parse(dateChunks[2]),
                int.Parse(dateChunks[1]),
                int.Parse(dateChunks[0]),

                int.Parse(timeChunks[0]),
                int.Parse(timeChunks[1]),
                int.Parse(timeChunks[2])
            );
        }

        public MovementsList GetAll() {
            string[] lines = GetAllLine();

            List<Movement> list = new List<Movement>();

            foreach(string line in lines) {
                string[] chunks = line.Split(",");

                //Id,AccountId,amount,type,date
                int id = int.Parse(chunks[0]);
                string accountId = chunks[1];
                double amount = double.Parse(chunks[2]);
                TYPE movementType = chunks[3] == "IN" ? TYPE.IN : TYPE.OUT;
                string date = chunks[4];

                list.Add(
                    new Movement(id, accountId, amount, GetDateTime(date), movementType)
                );
            }

            return new MovementsList(list.ToArray());
        }

        //public 
    }
}