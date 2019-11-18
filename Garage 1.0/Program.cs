using System;
using System.IO;
using Garage_1._0.Vehicles;

namespace Garage_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.MainMenu();
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
