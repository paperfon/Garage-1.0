using System;
using System.Collections.Generic;
using System.Text;

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
                + "\n2. List all the garages"
                + "\n0. Close the app");

            switch (input)
            {
                case 1:
                    // Create New Garage
                    GarageStarter();
                    break;
                case 2:
                    // List All Garages
                    break;
                case 0:
                    // Close App
                    return;
                default:
                    Console.WriteLine("Selection not valid, press any key to continue and then choose a number from the menu!\n");
                    Console.ReadKey();
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

                Console.WriteLine($"Garage {garage.Name}, with {garage.Capacity} has been created successfully, press a key to go back to the main menu!");
                Console.ReadKey();

                GarageMenu(garage);
                break;
            }

        }

        private static void GarageMenu(Garage<Vehicle> garage)
        {
            Console.Clear();
            var input = Utils.AskForNumber("Please select what you want to do:"
                + "\n1. List all parked vehicles"
                + "\n2. List how many of each vehicle type there is"
                + "\n3. Park a vehicle"
                + "\n4. Unpark a vehicle"
                + "\n5. Find a vehicle from its properties"
                + "\n6. Find a vehicle based on its registration number"
                + "\n0. Close the app");

            switch (input)
            {
                case 1:
                    handler.ListAllParkedVehicles(garage);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
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

        public static void SuccessActionMessage()
        {
            Console.WriteLine("The action was successfully performed!");
        }
    }
}
