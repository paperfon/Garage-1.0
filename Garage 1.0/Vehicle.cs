using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0
{
    public class Vehicle : IVehicle
    {
        public Vehicle(string regnumber, string color, int numberofwheels, string fabricant, int productionyear)
        {
            RegNumber = regnumber;
            Color = color;
            NumberOfWheels = numberofwheels;
            Fabricant = fabricant;
            ProductionYear = productionyear;
        }

        public virtual string Stats()
        {
            return $"\nThe stats for this vehicle are:" +
                $"\nType: {this.GetType().Name}" +
                $"\nRegNumber: {this.RegNumber}" +
                $"\nColor: {this.Color}" +
                $"\nNumberOfWheels: {this.NumberOfWheels}" +
                $"\nFabricant: {this.Fabricant}" +
                $"\nProductionYear: {this.ProductionYear}";
        }

        public string RegNumber { get; private set; }
        public string Color { get; private set; }
        public int NumberOfWheels { get; private set; }
        public string Fabricant { get; private set; }
        public int ProductionYear { get; private set; }
    }
}
