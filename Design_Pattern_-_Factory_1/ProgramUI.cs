using System;

namespace Design_Pattern___Factory_1
{
    internal class ProgramUI
    {
        VehicleFactory _factory = new ConcreteVehicleFactory();
        IVehicle _vehicle;
        string tank;

        public ProgramUI()
        {
        }

        internal void Run()
        {
            Console.WriteLine("\n\nWhat type of vehicle do you need? " +
                "1. Car");
            _vehicle = _factory.GetVehicle(Console.ReadLine());

            Console.WriteLine("\n\nGive the vehicle a model: ");
            _vehicle.Name = Console.ReadLine();

            Console.WriteLine("\n\nGive the vehicle a color: " +
                "1. Car");
            _vehicle.Color = Console.ReadLine();

            Console.WriteLine("\n\nHow many doors? " +
                "\n\n1. 2-Door \n2. 4-Door\n\n");
            _vehicle.DoorNumber = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("\n\nDoes the car have gas (y or n)? ");
            if (Console.ReadLine() == "y")
            {
                _vehicle.HasGas = true;
            }
            else
            {
                _vehicle.HasGas = false;
            }

            if (_vehicle.HasGas)
            {
               tank = "";
            }
            else
            {
                tank = "no ";
            }

            Console.Write($"You have a {_vehicle.Color} {_vehicle.Name} car with {_vehicle.DoorNumber} doors and has {tank}gas in the tank.");
        }
    }
}