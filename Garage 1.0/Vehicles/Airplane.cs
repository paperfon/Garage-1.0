using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Airplane : Vehicle
    {
        public Airplane(string regnumber, string fabricant, uint numberofwheels, string color, uint productionyear, uint numberofengines) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            NumberOfEngines = numberofengines;
        }

        public uint NumberOfEngines { get; private set; }
    }
}
