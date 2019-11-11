using System;

namespace Garage_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select what you want to do by choosing a number from this menu:"
                    + "\n1. Create a new garage"
                    + "\n2. List all the garages"
                    + "\nQ. Close the app");

                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("==> Please choose a number!\n");
                }

                switch (input)
                {
                    case '1':
                        CreateNewGarage();
                        break;
                    case '2':
                        ListAllGarages();
                        break;
                    case 'Q':
                        CloseApp();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("==> Selection not valid, please choose a number from the menu!\n");
                        break;
                }
            }
        }

        private static void CreateNewGarage()
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

                var creator = new Garage(inputName, inputCapacity);

                Console.WriteLine($"Garage {inputName} created successfully, press a key to go back to the main menu!");
                Console.ReadKey();
                break;
            }
        }

        private static void ListAllGarages()
        {
        }

        private static void CloseApp()
        {
        }
    }
}
