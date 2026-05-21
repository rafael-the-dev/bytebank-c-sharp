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
        private MovementsRepository _MovementsRepository;

        public SaveTransactionCommand(Movement transaction)
        {
            this.Transaction = transaction;
            this.TransactionId = -1;
            this._MovementsRepository = new MovementsRepository();
        }

        public void Execute()
        {
            int id = this._MovementsRepository.Save(this.Transaction.AccountId, this.Transaction);

            this.TransactionId = id;
        }

        public void Undo()
        {
            if (this.TransactionId == -1) return;

            this._MovementsRepository.Delete(this.TransactionId.ToString());

            this.TransactionId = -1;
        }
    }
}