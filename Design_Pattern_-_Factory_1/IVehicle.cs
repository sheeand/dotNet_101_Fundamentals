using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Design_Pattern___Factory_1.ConcreteVehicles.Car;

namespace Design_Pattern___Factory_1
{
    public enum NumberOfDoors { Two, Four, Other }

    interface IVehicle
    {

        string Name { get; set; }
        string Color { get; set; }
        bool HasGas { get; set; }
        int DoorNumber { get; set; }

        void FuelStatus();
        void Move();
        void Start();
        void Brake();
        //bool HasGas();
    }
}
