

namespace Module
{
    class Menu
    {
        private AccountsList AccountsList;

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

                if (controller == 1) CreateAccount();
                else if (controller == 4) Stats();

                if (controller != 0) Console.WriteLine();

            } while (controller != 0);
        }
    }
}