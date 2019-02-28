using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Demo1
{
    public class Student : Person
    {
        public char CurrentGrade { get; set; }

        public override void Greet()
        {
            Console.WriteLine($"I am {FirstName}. I am a student.");
        }

        public void GetTraining()
        {
            Console.WriteLine("You are being trained.");
        }

    }
}
