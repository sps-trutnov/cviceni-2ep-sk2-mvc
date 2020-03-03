using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _01_HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        // vyvola se v prohlizeci pomoci URL https://localhost:<port>/HelloWorld
        // nebo take kompletne s nazvem akce https://localhost:<port>/HelloWorld/Index
        public string Index()
        {
            return "Toto je defaultní akce controlleru HelloWorld.";
        }

        // vyvola se v prohlizeci pomoci URL https://localhost:<port>/HelloWorld/Pozdrav
        // pocet pozdravu se zadava do URL jako /HelloWorld/Pozdrav?kolikrat=6
        public string Pozdrav(int kolikrat = 1)
        {
            string vysledek = "";

            for (int i = 0; i < kolikrat; i++)
                vysledek += "Ahoj, světe!\n";

            return vysledek;
        }
    }
}