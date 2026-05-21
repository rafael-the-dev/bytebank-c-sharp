
using System;
using System.Collections.Generic;
//using System.Linq;

using ByteBank.Entities;
using ByteBank.Repositories;
using ByteBank.Menus;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.Render();
        }
    }
}