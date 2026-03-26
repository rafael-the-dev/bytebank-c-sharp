

using Module.Entities;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 500, 500);
            SavingAccount sacc = new SavingAccount(1003, "Ana", 500, 0.01);

            acc.Withdraw(10);
            bacc.Withdraw(10);
            sacc.Withdraw(10);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(bacc.Balance);
            Console.WriteLine(sacc.Balance);

        }
    }
}