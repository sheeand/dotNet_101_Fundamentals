using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Demo
{
    public class Bird : Animal
    {
        public override void GetMad()
        {
            Console.WriteLine("I fly at you!!");
        }

        public override void StateType()
        {
            throw new NotImplementedException();
        }
    }
}
