

namespace Module
{
    class Menu
    {
        private AccountsList AccountsList;

        enum Option: sbyte {
            CREATE_ACOUNT = 1,
            DEPOSIT_AMOUNT = 2,
            WITHDRAW_AMOUNT = 3,
            STATS = 4
        }

        public Menu()
        {
            this.AccountsList = new AccountsList();
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

            account.AdicionarValor(amount);
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

            account.RemoverValor(amount);
        }

        private void Stats()
        {
            Console.WriteLine(this.AccountsList.ToString());
        }

        public void Render()
        {
            sbyte controller = 0;
           

            do
            {

                Console.WriteLine("Escolha uma das opções abaixo");
                Console.WriteLine("1 ==== Criar conta\n2 ==== Depositar\n3 ==== Debitar\n4 ==== Estatistica\nZero ==== Terminar");
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
                    case Option.STATS:
                        Stats();
                        break;
                }

                if (controller != 0) Console.WriteLine();

            } while (controller != 0);
        }
    }
}