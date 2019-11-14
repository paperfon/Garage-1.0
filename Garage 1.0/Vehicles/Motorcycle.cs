using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string regnumber, string color, int numberofwheels, string fabricant, int productionyear, int cylindervolume) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            CylinderVolume = cylindervolume;
        }

        public int CylinderVolume { get; private set; }
    }
}
