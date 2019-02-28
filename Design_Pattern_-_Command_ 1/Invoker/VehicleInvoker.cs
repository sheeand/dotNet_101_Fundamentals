using Design_Pattern___Command__1.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command__1.Invoker
{
    class VehicleInvoker
    {
        //-- Field that allows us to pass in a command

        private ICommand _TurnOn, _TurnOff, _SpeedUp, _Brake;

        //-- same as typing it all out:
        //private ICommand _TurnOn;
        //private ICommand _TurnOff;
        //private ICommand _Speedup;
        //private ICommand _Brake;

        public VehicleInvoker(ICommand turnOn, ICommand turnOff, ICommand speedUp, ICommand brake)
        {
            _TurnOn = turnOn;
            _TurnOff = turnOff;
            _SpeedUp = speedUp;
            _Brake = brake;
        }

        //--  Invoker Mothods
        public void TurnOn()
        {
            _TurnOn.Execute();  // This is the command that turns on the vehicle
        }

        public void TurnOff()
        {
            _TurnOff.Execute();  // This is the command that turns off the vehicle
        }

        public void SpeedUp()
        {
            _SpeedUp.Execute();  // This is the command that speeds upthe vehicle
        }

        public void Brake()
        {
            _TurnOn.Execute();  // This is the command that applies the brake the vehicle
        }

    }
}
