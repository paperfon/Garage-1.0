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

        public void ListAllParkedVehicles(Garage<Vehicle> garage)
        {
            UI.DisplayParkedVehicles(garage.ListAllParkedVehicles());
        }

        public void ListAmountAndVehicleType(Garage<Vehicle> garage)
        {
            UI.ListVehiclesTypes(garage.ListAmountAndVehicleType());
        }

        public void ParkVehicle(Garage<Vehicle> garage, Vehicle vehicle)
        {
            if (garage.ParkVehicle(vehicle)) { UI.SuccessParkedMessage(); }
        }

        public void UnparkVehicle(Garage<Vehicle> garage, string regnumber)
        {
            if (garage.UnparkVehicle(regnumber)) { UI.SuccessUnparkMessage(); }
            else { UI.FailedParkMessage(); }
        }

        public void FindVehicle()
        {

        }

        public void FindVehicleOnRegNumber()
        {

        }
    }
}
