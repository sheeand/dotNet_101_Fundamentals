using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Demo
{
    // An abstract class is a base class
    // You cannot instantiate a base class, but you can instantiate a class that inherits it
    // Works like an interface, but actually has logic in it
    public abstract class Animal
    {
        private string _latinName;

        public bool hasLegs { get; set; }
        public int? Legs { get; set; }
        public string Name { get; set; }


        public string LatinName
        {
            get => _latinName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Can't be empty");
                _latinName = value;
            }
        }

        public abstract void StateType();
        public abstract void GetMad();

    }
}
