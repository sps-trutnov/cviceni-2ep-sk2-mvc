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
        public string Pozdrav()
        {
            return "Ahoj, světe!";
        }
    }
}