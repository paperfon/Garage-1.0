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
            garage.ListAllParkedVehicles();
        }

        public void ListAmountAndVehicleType(Garage<Vehicle> garage)
        {
            garage.ListAmountAndVehicleType();
        }

        public void ParkVehicle(Garage<Vehicle> garage, Vehicle vehicle)
        {
            if (garage.ParkVehicle(vehicle)) { UI.SuccessActionMessage(); }
        }

        public void UnparkVehicle(Garage<Vehicle> garage, Vehicle vehicle)
        {
            if (garage.UnparkVehicle(vehicle)) { UI.SuccessActionMessage(); }
        }

        public void FindVehicle()
        {

        }

        public void FindVehicleOnRegNumber()
        {

        }
    }
}
