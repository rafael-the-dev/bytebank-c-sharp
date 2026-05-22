using System;

using ByteBank.Entities;
using ByteBank.Commands;

namespace ByteBank.Menus
{
    class Menu
    {
        private AccountsList AccountsList;

        enum Option: sbyte {
            CREATE_ACOUNT = 1,
            DEPOSIT_AMOUNT = 2,
            WITHDRAW_AMOUNT = 3,
            DELETE_ACCOUNT = 4,
            ACCOUNTS = 5,
            TRANSACTIONS = 6,
            STATS = 7,
        }

        public Menu()
        {
            this.AccountsList = new AccountsList();

            //this.AccountsList.Load();
        }

        private void AccountsMenu()
        {
            AccountsMenu menu = new AccountsMenu();
            menu.Render();
        }

        private void CreateAccount()
        {
            Console.Write("Insere o nome: ");
            string name = Console.ReadLine();

            Console.Write("Insere o ID: ");
            string id = Console.ReadLine();

            Console.Write("Saldo inicial: ");
            double amount = double.Parse(Console.ReadLine());

            if (name != null && id != null)
            {
                this.AccountsList.Add(new Account(new Client(name), id, amount));
            }
        }

        private void Deposit()
        {
            Console.Write("Insere o ID da conta: ");
            string id = Console.ReadLine();

            Account? account = this.AccountsList.get(id);

            if(account == null)
            {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            Console.Write("Insere o valor: ");
            double amount = double.Parse(Console.ReadLine());

            Invoker invoker = new Invoker();

            invoker.RunBatch([
                new DepositCommand(account, amount, account.Amount),
                new SaveTransactionCommand(new Movement(-1, account.Id, amount, DateTime.Now, TYPE.IN))
            ]);

            //account.AdicionarValor(amount);
            this.AccountsList.Reload();
        }

        private void Debitar()
        {
            Console.Write("Insere o ID da conta: ");
            string id = Console.ReadLine();

            Account? account = this.AccountsList.get(id);

            if (account == null)
            {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            Console.Write("Insere o valor: ");
            double amount = double.Parse(Console.ReadLine());

            Invoker invoker = new Invoker();

            //account.RemoverValor(amount);

            invoker.RunBatch([
                new WithdrawCommand(account, amount, account.Amount),
                new SaveTransactionCommand(new Movement(-1, account.Id, amount, DateTime.Now, TYPE.OUT))
            ]);

            this.AccountsList.Reload();
        }

        private void RemoveAccount() {
            Console.Write("Insere o ID da conta: ");
            string id = Console.ReadLine();

            this.AccountsList.Remove(id);
        }

        private void Stats()
        {
            Console.WriteLine(this.AccountsList.ToString());
        }

        public void Render()
        {
            sbyte controller = 0;

            this.AccountsList.Reload();
           

            do
            {

                Console.WriteLine("Escolha uma das opções abaixo");
                Console.WriteLine("1 ==== Criar conta\n2 ==== Depositar\n3 ==== Debitar\n4 ==== Apagar conta\n5 ==== Contas\n6 ==== Transações\n7 ==== Estatistica\nZero = Terminar");
                controller = sbyte.Parse(Console.ReadLine());

                switch((Option)controller)
                {
                    case Option.CREATE_ACOUNT:
                        CreateAccount();
                        break;
                    case Option.DEPOSIT_AMOUNT:
                        Deposit();
                        break;
                    case Option.WITHDRAW_AMOUNT:
                        Debitar();
                        break;
                    case Option.DELETE_ACCOUNT:
                        RemoveAccount();
                        break;
                    case Option.ACCOUNTS:
                        AccountsMenu();
                        break;
                    case Option.TRANSACTIONS: {
                        TransactionMenu menu = new TransactionMenu();
                        menu.Render();
                        break;
                    }
                    case Option.STATS:
                        Stats();
                        break;
                }

                if (controller != 0) Console.WriteLine();

            } while (controller != 0);
        }
    }
}