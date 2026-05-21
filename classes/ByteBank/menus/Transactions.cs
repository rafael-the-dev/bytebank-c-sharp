using System;
using System.Collections.Generic;

using ByteBank.Entities;
using ByteBank.Repositories;

namespace ByteBank.Menus { 
    public class TransactionMenu {
        enum Option : sbyte
        {
            ALL_BY_ACCOUNT = 1,
            ALL = 2,
        }

        private AccountsList AccountsList;
        private MovementsList MovementsCollection;
        private MovementsRepository Repo;

        public TransactionMenu() {
            this.AccountsList = new AccountsList();
            this.MovementsCollection = new MovementsList([]);
            this.Repo = new MovementsRepository();
        }

        public void Reload() {
            this.AccountsList.Reload();
            this.MovementsCollection = this.Repo.GetAll();
        }

        private string GetColumn(string value, byte maxLength) {
            string column = value;
            
            while(column.Length <= maxLength) {
                column += " ";
            }

            return column;
        }

        private void Print(Movement[] list) {
            Console.WriteLine($"{GetColumn("ID", 6)}{GetColumn("Valor", 10)}{GetColumn("Tipo", 12)}{GetColumn("Data", 12)}");

            foreach(Movement movement in list) {
                Console.WriteLine($"{GetColumn(movement.Id.ToString(), 6)}{GetColumn(movement.Amount.ToString(), 10)}{GetColumn(movement.Type == TYPE.IN ? "Crédito" : "Débito", 12)}{GetColumn(movement.Date.ToString(), 12)}");
            }
        }

        private void RenderAllByAccountId() {
            Console.Write("Insere o número da conta: ");
            string accountId = Console.ReadLine();

            Account? account = this.AccountsList.get(accountId);

            if(account == null) {
                Console.WriteLine("Conta não encontrada");
                return;
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Nome: {account.Holder.Name}\nSaldo: {account.Amount}\n");

            List<Movement> data = this.MovementsCollection.GetByAccountId(accountId);

            Print(data.ToArray());
        }

        public void Render() {
            sbyte controller = 0;
            
            this.Reload();


            do
            {

                Console.WriteLine("Escolha uma das opções abaixo");
                Console.WriteLine("1 ==== Transaçoes Por Conta\n2 ==== Ver Todas Transações\nZero ==== Voltar");
                controller = sbyte.Parse(Console.ReadLine());

                switch ((Option)controller)
                {
                    case Option.ALL_BY_ACCOUNT:
                        RenderAllByAccountId();
                        break;
                }

                if (controller != 0) Console.WriteLine();

            } while (controller != 0);
        }
    }
}