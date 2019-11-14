using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Airplane : Vehicle
    {
        public Airplane(string regnumber, string color, int numberofwheels, string fabricant, int productionyear, int numberofengines) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            NumberOfEngines = numberofengines;
        }

        public int NumberOfEngines { get; private set; }
    }
}
