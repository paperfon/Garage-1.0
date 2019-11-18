namespace Garage_1._0
{
    interface IGarageHandler
    {
        Garage<Vehicle> CreateGarage(string name, uint maxcapacity);
        void FindVehicleOnProperties(Garage<Vehicle> garage, string typeofvehicle = "", string fabricant = "", uint numberofwheels = 0, string color = "", uint productionyear = 0);
        void FindVehicleOnRegNumber(Garage<Vehicle> garage, string regnumber);
        void ListParkedVehicles(Garage<Vehicle> garage);
        void ListVehicleTypes(Garage<Vehicle> garage);
        void ParkVehicle(Garage<Vehicle> garage, Vehicle vehicle);
        void UnparkVehicle(Garage<Vehicle> garage, string regnumber);
    }
}