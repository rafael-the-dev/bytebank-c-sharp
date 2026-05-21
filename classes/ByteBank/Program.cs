
using ByteBank.Module;
using ByteBank.Entities;
using System;
using System.Collections.Generic;
//using System.Linq;

using ByteBank.Entities;
using ByteBank.Repositories;

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