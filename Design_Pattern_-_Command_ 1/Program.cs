using Design_Pattern___Command__1.Command;
using Design_Pattern___Command__1.Command.ConcreteCommands;
using Design_Pattern___Command__1.Invoker;
using Design_Pattern___Command__1.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Command__1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-- Receiver
            IVehicle car = new Car();
            IVehicle bus = new Bus();

            //-- Concrete commands 
            ICommand turnOnCarCommand = new TurnOnVehicle(car); // for a command you need a 
            ICommand turnOffCarCommand = new TurnOffVehicle(car); 
            ICommand speedUpCarCommand = new SpeedUpVehicle(car); 
            ICommand brakeCarCommand = new BrakeVehicle(car);

            ICommand turnOnBusCommand = new TurnOnVehicle(bus);
            ICommand turnOffBusCommand = new TurnOffVehicle(bus);
            ICommand speedUpBusCommand = new SpeedUpVehicle(bus);
            ICommand brakeBusCommand = new BrakeVehicle(bus);


            //                                             (the order of the parameters must match that of the invoker)
            //-- Invoker                                     /                                                       \
            VehicleInvoker carInvoker = new VehicleInvoker(turnOnCarCommand, turnOffCarCommand, speedUpCarCommand, brakeCarCommand);

            VehicleInvoker busInvoker = new VehicleInvoker(turnOnBusCommand, turnOffBusCommand, speedUpBusCommand, brakeBusCommand);


            carInvoker.TurnOn();
            carInvoker.SpeedUp();
            carInvoker.Brake();
            carInvoker.TurnOff();

            busInvoker.TurnOn();
            busInvoker.SpeedUp();
            busInvoker.Brake();
            busInvoker.TurnOff();

            Console.ReadLine();
        }
    }
}
