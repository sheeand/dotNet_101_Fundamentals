using Design_Pattern___Command__1.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command__1.Command.ConcreteCommands
{
    class SpeedUpVehicle : ICommand
    {
        private IVehicle _vehicle;

        public SpeedUpVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Execute()
        {
            _vehicle.SpeedUp(); // This is the beauty of the Command Design Pattern
        }
    }
}
