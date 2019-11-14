using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Bus : Vehicle
    {
        public Bus(string regnumber, string color, int numberofwheels, string fabricant, int productionyear, int numberofseats) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            NumberOfSeats = numberofseats;
        }

        public int NumberOfSeats { get; private set; }
    }
}
