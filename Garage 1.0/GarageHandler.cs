using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0
{
    class GarageHandler
    {
        public Garage<Vehicle> CreateGarage(string name, uint maxcapacity)
        {
            return new Garage<Vehicle>(name, maxcapacity);
        }

        public void ListParkedVehicles(Garage<Vehicle> garage)
        {
            UI.DisplayParkedVehicles(garage.ListParkedVehicles());
        }

        public void ListVehicleTypes(Garage<Vehicle> garage)
        {
            UI.ListVehiclesTypes(garage.ListVehicleTypes());
        }

        public void ParkVehicle(Garage<Vehicle> garage, Vehicle vehicle)
        {
            if (garage.ParkVehicle(vehicle)) { UI.SuccessParkedMessage(); }
        }

        public void UnparkVehicle(Garage<Vehicle> garage, string regnumber)
        {
            if (garage.UnparkVehicle(regnumber)) { UI.SuccessUnparkMessage(); }
            else { UI.FailedUnparkMessage(); }
        }

        public void FindVehicleOnRegNumber(Garage<Vehicle> garage, string regnumber)
        {
            if (garage.FindVehicleOnRegnumber(regnumber)) { UI.SuccessFoundVehicle(); }
            else { UI.FailedFoundVehicle(); }
        }

        public void FindVehicleOnProperties(Garage<Vehicle> garage, string fabricant = "", uint numberofwheels = 0, string color = "", uint productionyear = 0)
        {
            UI.DisplayParkedVehicles(garage.FindVehicleOnProperties(fabricant, numberofwheels, color,  productionyear));
        }
    }
}
