using Design_Pattern___Factory_1.ConcreteVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Factory_1
{
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    return new Car();
                default:
                    throw new ApplicationException("No car");
            }
        }

        //public override IVehicle GetVehicle(IVehicle vehicle)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
