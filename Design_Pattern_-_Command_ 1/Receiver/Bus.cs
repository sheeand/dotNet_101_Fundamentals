using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command__1.Receiver
{
    class Bus : IVehicle
    {
        public void Brake()
        {
            Console.WriteLine("Slowing down the bus");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Speeding up the bus");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the bus");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on the bus");
        }
    }
}
