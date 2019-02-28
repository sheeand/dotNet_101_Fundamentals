using Design_Pattern___Command__1.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command__1.Command.ConcreteCommands
{
    class TurnOffVehicle : ICommand
    {
        private IVehicle _vehicle;

        public TurnOffVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Execute()
        {
            _vehicle.TurnOff(); // This is the beauty of the Command Design Pattern
        }
    }
}
