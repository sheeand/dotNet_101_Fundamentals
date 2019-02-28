using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Factory_1.ConcreteVehicles
{
    public class Car : IVehicle
    {

        public string Name { get; set; }
        public string Color { get; set; }
        public int DoorNumber { get; set; }
        public bool HasGas { get; set; }

        public void Brake()
        {
            Console.WriteLine("Car is braking");
        }

        public void FuelStatus()
        {
            if (HasGas)
            {
                Console.WriteLine("Tank is full");
            }
            else
            {
                Console.WriteLine("Tank is empty");
            }
        }

        public void Move()
        {
            Console.WriteLine("Tank is moving");
        }

        public void Start()
        {
            Console.WriteLine("Tank is starting");
        }
    }
}
