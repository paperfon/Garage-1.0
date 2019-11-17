using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string regnumber, string color, uint numberofwheels, string fabricant, uint productionyear, uint cylindervolume) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            CylinderVolume = cylindervolume;
        }

        public uint CylinderVolume { get; private set; }
    }
}
