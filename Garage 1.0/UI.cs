using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Garage_1._0.Vehicles;

namespace Garage_1._0
{
    class UI
    {
        static GarageHandler handler = new GarageHandler();
        static public void MainMenu()
        {
            Console.Clear();
            var input = Utils.AskForNumber("Please select what you want to do by choosing a number from this menu:"
                + "\n1. Create a new garage"
                // + "\n2. List all the garages"
                + "\n0. Close the app");

            switch (input)
            {
                case 1:
                    GarageStarter();
                    break;
                // case 2:
                //     break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Please write a valid selection!\n");
                    // Console.ReadKey();
                    MainMenu();
                    break;
            }

        }

        private static void GarageStarter()
        {
            while (true)
            {
                Console.Clear();
                string inputName = Utils.AskForInput("Please write the name of the garage:\n"
                    + "(Press 0 to go back)");
                if (inputName == "0") break;

                uint inputCapacity = Utils.AskForNumber("Write the capacity of the garage:\n"
                    + "(Press 0 to cancel and go back)");
                if (inputCapacity == 0) break;

                var garage = handler.CreateGarage(inputName, inputCapacity);

                Console.WriteLine($"Garage named {garage.Name} with a capacity of {garage.Capacity} has been created successfully!");
                // Console.ReadKey();
                GarageMenu(garage);
                break;
            }
        }

        private static void GarageMenu(Garage<Vehicle> garage)
        {
            // Console.Clear();
            Console.WriteLine();
            var input = Utils.AskForNumber("\n***************************************************"
                + "\nPlease select what you want to do:"
                + "\n1. List all parked vehicles"
                + "\n2. List how many of each vehicle type there is"
                + "\n3. Park a vehicle"
                + "\n4. Unpark a vehicle"
                + "\n5. Find a vehicle from its properties"
                + "\n6. Find a vehicle based on its registration number"
                + "\n0. Go back to the main menu"
                + "\n***************************************************");

            switch (input)
            {
                case 1:
                    handler.ListParkedVehicles(garage);
                    GarageMenu(garage);
                    break;
                case 2:
                    handler.ListVehicleTypes(garage);
                    GarageMenu(garage);
                    break;
                case 3:
                    CreateAndParkVehicleMenu(garage);
                    break;
                case 4:
                    handler.UnparkVehicle(garage, Utils.AskForInput("Write the registration number of the cark you want to unpark:"));
                    GarageMenu(garage);
                    break;
                case 5:
                    FindVehicleByPropertiesMenu(garage);
                    break;
                case 6:
                    handler.FindVehicleOnRegNumber(garage, Utils.AskForInput("If you want to check if a car is parked in the garage write its registration number:"));
                    GarageMenu(garage);
                    break;
                case 0:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Selection not valid, press any key to continue and then choose a number from the menu!\n");
                    Console.ReadKey();
                    GarageMenu(garage);
                    break;
            }
        }

        private static void CreateAndParkVehicleMenu(Garage<Vehicle> garage)
        {
            // Todo: check first if the garage is full??
            var input = Utils.AskForNumber("\nWhich vehicle do you want to park?"
                + "\n1. Airplane"
                + "\n2. Boat"
                + "\n3. Bus"
                + "\n4. Car"
                + "\n5. Motorcycle"
                + "\n0. Go back to the garage menu"
                + "\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");

            var promptRegNumber = "Registration number:";
            var promptFabricant = "Brand:";
            var promptNumberOfWheels = "Number of wheels:";
            var promptColor = "Color:";
            var promptYearOfProduction = "Year of production:";

            switch (input)
            {
                case 1:
                    var airplane = new Airplane(
                        regnumber: Utils.AskForInput(promptRegNumber),
                        fabricant: Utils.AskForInput(promptFabricant),
                        numberofwheels: Utils.AskForNumber(promptNumberOfWheels),
                        color: Utils.AskForInput(promptColor),
                        productionyear: Utils.AskForNumber(promptYearOfProduction),
                        numberofengines: Utils.AskForNumber("Number of engines:")
                        );
                    handler.ParkVehicle(garage, airplane);
                    CreateAndParkVehicleMenu(garage);
                    break;
                case 2:
                    var boat = new Boat(
                            regnumber: Utils.AskForInput(promptRegNumber),
                            fabricant: Utils.AskForInput(promptFabricant),
                            numberofwheels: Utils.AskForNumber(promptNumberOfWheels),
                            color: Utils.AskForInput(promptColor),
                            productionyear: Utils.AskForNumber(promptYearOfProduction),
                            length: Utils.AskForNumber("Length:")
                            );
                    handler.ParkVehicle(garage, boat);
                    CreateAndParkVehicleMenu(garage);
                    break;
                case 3:
                    var bus = new Bus(
                            regnumber: Utils.AskForInput(promptRegNumber),
                            fabricant: Utils.AskForInput(promptFabricant),
                            numberofwheels: Utils.AskForNumber(promptNumberOfWheels),
                            color: Utils.AskForInput(promptColor),
                            productionyear: Utils.AskForNumber(promptYearOfProduction),
                            numberofseats: Utils.AskForNumber("Number of seats:")
                            );
                    handler.ParkVehicle(garage, bus);
                    CreateAndParkVehicleMenu(garage);
                    break;
                case 4:
                    var car = new Car(
                            regnumber: Utils.AskForInput(promptRegNumber),
                            fabricant: Utils.AskForInput(promptFabricant),
                            numberofwheels: Utils.AskForNumber(promptNumberOfWheels),
                            color: Utils.AskForInput(promptColor),
                            productionyear: Utils.AskForNumber(promptYearOfProduction),
                            fueltype: Utils.AskForInput("Fuel type:")
                            );
                    handler.ParkVehicle(garage, car);
                    CreateAndParkVehicleMenu(garage);
                    break;
                case 5:
                    var motorcycle = new Motorcycle(
                            regnumber: Utils.AskForInput(promptRegNumber),
                            fabricant: Utils.AskForInput(promptFabricant),
                            numberofwheels: Utils.AskForNumber(promptNumberOfWheels),
                            color: Utils.AskForInput(promptColor),
                            productionyear: Utils.AskForNumber(promptYearOfProduction),
                            cylindervolume: Utils.AskForNumber("Cylinder volume:")
                            );
                    handler.ParkVehicle(garage, motorcycle);
                    CreateAndParkVehicleMenu(garage);
                    break;
                case 0:
                    GarageMenu(garage);
                    break;
                default:
                    Console.WriteLine("Please make a valid selection!\n");
                    CreateAndParkVehicleMenu(garage);
                    break;
            }
        }

        private static void FindVehicleByPropertiesMenu(Garage<Vehicle> garage)
        {
            var input = Utils.AskForNumber("\nSelect multiple properties one by one and then press 5 to filter from the parked vehicles"
                + "\n1. Fabricant"
                + "\n2. Number of wheels"
                + "\n3. Color"
                + "\n4. Production year"
                + "\n5. Filter"
                + "\n0. Go back to the garage menu"
                + "\n_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");

            string fabricant = "";
            uint numberofwheels = 0;
            string color = "";
            uint productionyear = 0;

            switch (input)
            {
                case 1:
                    fabricant = Utils.AskForInput("");
                    FindVehicleByPropertiesMenu(garage);
                    break;
                case 2:
                    numberofwheels = Utils.AskForNumber("");
                    FindVehicleByPropertiesMenu(garage);
                    break;
                case 3:
                    color = Utils.AskForInput("");
                    FindVehicleByPropertiesMenu(garage);
                    break;
                case 4:
                    productionyear = Utils.AskForNumber("");
                    FindVehicleByPropertiesMenu(garage);
                    break;
                case 5:
                    handler.FindVehicleOnProperties(garage, fabricant, numberofwheels, color, productionyear);
                    GarageMenu(garage);
                    break;
                case 0:
                    GarageMenu(garage);
                    break;
                default:
                    Console.WriteLine("Please make a valid selection!\n");
                    FindVehicleByPropertiesMenu(garage);
                    break;
            }
        }

        public static void SuccessParkedMessage()
        {
            Console.WriteLine("The vehicle was successfully parked!");
        }

        public static void SuccessUnparkMessage()
        {
            Console.WriteLine("The vehicle was unparked!");
        }

        internal static void FailedParkMessage()
        {
            Console.WriteLine("The garage is full!");
        }
        internal static void ListVehiclesTypes(IEnumerable<IGrouping<string, Vehicle>> listOfVehiclesByType)
        {
            foreach (var item in listOfVehiclesByType)
            {
                if (string.IsNullOrEmpty(item.Key)) { }
                else
                {
                    Console.WriteLine("The garage contains {0} unit(s) of this type of vehicle: {1}",
                        item.Count(),
                        item.Key);
                }
            }
        }

        internal static void DisplayParkedVehicles(IEnumerable<Garage_1._0.Garage<Vehicle>.ExportedListOfVehicles> parkedVehicles)
        {
            Console.WriteLine("\nThe parked vehicles in the garage are:");
            foreach (var item in parkedVehicles)
            {
                Console.WriteLine("\nParking Spot Nr: " + item.ParkingSpot
                    + "\nVehicle Type: " + item.TypeOfVehicle
                    + "\nReg Number: " + item.RegNumber
                    + "\nFabricant: " + item.Fabricant
                    + "\nNumber of Wheels: " + item.NumberOfWheels
                    + "\nColor: " + item.Color
                    + "\nProduction Year: " + item.ProductionYear
                    + "\n- - - - - - -");
            }
        }
        internal static void FailedFoundVehicle()
        {
            Console.WriteLine("The vehicle with that regnumber was not found");
        }

        internal static void SuccessFoundVehicle()
        {
            Console.WriteLine($"The vehicle was found at the parking");
        }
    }
}
