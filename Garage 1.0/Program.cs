using System;

namespace Garage_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select what you want to do by choosing a number from this menu:"
                    + "\n1. Create a new garage"
                    + "\n2. List all the garages"
                    + "\n3. Close the app");

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

                //char input = Console.ReadLine()[0];

                switch (input)
                {
                    case '1':
                        CreateNewGarage();
                        break;
                    case '2':
                        ListAllGarages();
                        break;
                    case '3':
                        CloseApp();
                        //Console.ReadKey();
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
        }

        private static void ListAllGarages()
        {
        }

        private static void CloseApp()
        {
        }
    }
}
