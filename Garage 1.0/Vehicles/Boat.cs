using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Boat : Vehicle
    {
        public Boat(string regnumber, string color, int numberofwheels, string fabricant, int productionyear, int length) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            Length = length;
        }

        public int Length { get; private set; }
    }
}
