﻿using System;
using Util.Selenium.Factories;

namespace Util.Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Início Processo -----");

            Driver.Instantiate(BrowserType.Chrome);
            ImbdFactory _imbdFactory = new ImbdFactory();
            _imbdFactory.BuscarFilme("...E o Vento Levou");

            Console.WriteLine("----- Fim Processo -----");
        }
    }
}
