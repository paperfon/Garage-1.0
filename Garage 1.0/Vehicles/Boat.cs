using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Boat : Vehicle
    {
        public Boat(string regnumber, string color, uint numberofwheels, string fabricant, uint productionyear, uint length) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            Length = length;
        }

        public uint Length { get; private set; }
    }
}
