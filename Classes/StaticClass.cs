using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class StaticClass
    {
        // поля
        public static string name = "Maxim";

        static StaticClass()
        { 
            //throw new Exception("Static constructor");
        }

        // методи
        public static void Introduce()
        {
            Console.WriteLine($"Hi, my name is {name}");
        }
    }
}
