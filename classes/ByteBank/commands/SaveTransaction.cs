using System;

using ByteBank.Entities;
using ByteBank.Interfaces;
using ByteBank.Repositories;

namespace ByteBank.Commands
{
    class SaveTransactionCommand : ICommand
    {
        public Movement Transaction { get; private set; }
        private int TransactionId;

        public SaveTransactionCommand(Movement transaction)
        {
            this.Transaction = transaction;
            this.TransactionId = -1;
        }

        public void Execute()
        {
            int id = MovementsRepository.Save(this.Transaction.AccountId, this.Transaction);

            this.TransactionId = id;
        }

        public void Undo()
        {
            if (this.TransactionId == -1) return;

            MovementsRepository.Delete(this.TransactionId.ToString());

            this.TransactionId = -1;
        }
    }
}