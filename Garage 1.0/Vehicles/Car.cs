using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0.Vehicles
{
    class Car : Vehicle
    {
        public Car(string regnumber, string color, int numberofwheels, string fabricant, int productionyear, string fueltype) : base(regnumber, color, numberofwheels, fabricant, productionyear)
        {
            FuelType = fueltype;
        }

        public string FuelType { get; private set; }
    }
}
