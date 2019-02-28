using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Demo
{
    class Bear : Animal
    {
        public override void StateType()
        {
            Console.WriteLine("Roar!!");
        }

        public override void GetMad()
        {
            Console.WriteLine("Roar!!");
        }
    }
}
