using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo1
{
    class Instructor : Person
    {
        public override void Greet()
        {
            //base.Greet();
            Console.WriteLine($"Hello {FirstName}. You are an instructor");
        }

        public void GetTraining()
        {
            Console.WriteLine("You are training.");
        }

    }
}
