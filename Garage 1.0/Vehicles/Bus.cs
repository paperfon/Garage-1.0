using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Bus : Vehicle
    {
        public Bus(string regnumber, string color, uint numberofwheels, string fabricant, uint productionyear, uint numberofseats) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            NumberOfSeats = numberofseats;
        }

        public uint NumberOfSeats { get; private set; }
    }
}
