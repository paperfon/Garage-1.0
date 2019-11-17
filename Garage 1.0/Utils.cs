using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_1._0
{
    public static class Utils
    {
        internal static string AskForInput(string prompt)
        {
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                Console.WriteLine();
                if (!string.IsNullOrEmpty(input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nPlease input something!");
                }
            } while (true);

            return input;
        }

        internal static uint AskForNumber(string prompt)
        {
            bool converted;
            uint number;
            do
            {
                string value = AskForInput(prompt);
                converted = uint.TryParse(value, out number);
                if (!converted)
                {
                    Console.WriteLine("Please write a valid number only!");
                }
            } while (!converted);
            return number;
        }
    }
}
