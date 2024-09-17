using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Animal
{
    public class Dog : Animal
    {
        public string Nickname { get; set; }

        public new void Sound()
        { 
            Console.WriteLine("Bark");
        }
    }
}
