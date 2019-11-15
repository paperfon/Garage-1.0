using System;
using System.IO;
using Garage_1._0.Vehicles;

namespace Garage_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //UI.MainMenu();

            var creator = new GarageHandler();

            var garage = creator.CreateGarage("ABC garage", 4);
            Console.WriteLine($"Garage '{garage.Name}' with {garage.Capacity} parking places has been created successfully, press a key to go back to the main menu!");

            var airplane = new Airplane("reg321", "blue", 4, "Volvo", 1995, 4);
            var boat = new Boat("reg123", "blue", 4, "Volvo", 1995, 45);
            var bus = new Bus("reg123", "blue", 4, "Volvo", 1995, 44);
            var car = new Car("reg123", "blue", 4, "Volvo", 1995, "Gasoline");
            var motorcycle = new Motorcycle("reg123", "blue", 2, "Volvo", 1995, 50);
            var motorcycle2 = new Motorcycle("reg456", "green", 2, "Volvo", 2019, 50);

            creator.ParkVehicle(garage, airplane);
            creator.ParkVehicle(garage, boat);
            creator.ParkVehicle(garage, motorcycle);
            creator.ParkVehicle(garage, motorcycle2);
            //creator.ParkVehicle(garage, bus);
            //creator.ParkVehicle(garage, car);
            creator.ListAllParkedVehicles(garage);
            creator.ListAmountAndVehicleType(garage);
            creator.UnparkVehicle(garage, "reg456");
            creator.ListAllParkedVehicles(garage);
            creator.ListAmountAndVehicleType(garage);

            creator.FindVehicleOnRegNumber(garage, "reg321");
            //creator.FindVehicleOnRegNumber(garage, "reg123");
            //creator.FindVehicleOnRegNumber(garage, "reg456777");
        }

        // Todo: Writing the object to a file and loading from a file
        //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{creator.Name}.txt");
        //string path = @"C:\Users\Elev\source\repos\Garage 1.0\Garage 1.0\";
        //string fullPath = path + $"GAR-{creator.Name}.txt";
        //Console.WriteLine(fullPath);

        //File.WriteAllText(fullPath, $"{creator.Name}{creator.Capacity}");

        //using (var writer = File.AppendText($"{creator.Name}.txt"))
        //{
        //    writer.WriteLine(creator);
        //    writer.WriteLine(creator.Capacity);
        //}
    }
}
