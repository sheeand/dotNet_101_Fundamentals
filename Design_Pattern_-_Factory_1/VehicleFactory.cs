using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Factory_1
{
    abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string userInput);

        //public abstract void GetVehicle(IVehicle vehicle)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
