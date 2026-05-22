using System;
using System.Collections.Generic;

using ByteBank.Entities;

namespace ByteBank.Menus {
    public class AccountsMenu : BaseMenu<Account>
    {
        enum OPTIONS : sbyte {
            GET = 1,
            UPDATE = 2,
            GET_ALL = 3
        }

        private AccountsList AccountsList;

        public AccountsMenu()
        {
            this.AccountsList = new AccountsList();
        }

        private void Reload()
        {
            this.AccountsList.Reload();
        }

        public override void Print(Account[] list)
        {
            Console.WriteLine($"{GetColumn("ID", 6)}{GetColumn("Nome", 30)}{GetColumn("Saldo", 12)}");

            foreach (Account account in list)
            {
                Console.WriteLine($"{GetColumn(account.Id, 6)}{GetColumn(account.Holder.Name, 30)}{GetColumn(account.Amount.ToString(), 12)}");
            }
        }

        private void GetAll()
        {
            List<Account> list = this.AccountsList.GetAll();
            Console.WriteLine("Todas as contas: ");
            Print(list.ToArray());
        }

        public void Render()
        {
            sbyte controller = 0;

            this.Reload();

            do 
            {

                Console.WriteLine("Escolha uma das opções abaixo");
                Console.WriteLine("1 ==== Dados da Conta\n2 ==== Atualizar Conta\n3 ==== Ver todas contas\nZero ==== Voltar");
                controller = sbyte.Parse(Console.ReadLine());

                switch ((OPTIONS)controller)
                {
                    //case Option.ALL_BY_ACCOUNT:
                    //    RenderAllByAccountId();
                    //    break;
                    case OPTIONS.GET_ALL:
                        GetAll();
                        break;
                }

                if (controller != 0) Console.WriteLine();

            } while (controller != 0);
        }
    }
}