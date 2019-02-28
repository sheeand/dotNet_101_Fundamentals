using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo1
{
    public abstract class Person
    {
        public string FirstName { get; set; }

        public virtual void Greet()
        {
            Console.WriteLine($"I am {FirstName}");
        }

        public virtual void Greet(string mood)
        {
            Console.WriteLine($"I am {FirstName}. I am {mood}.");
        }
    }
}
