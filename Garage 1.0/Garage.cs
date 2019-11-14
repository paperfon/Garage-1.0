using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage_1._0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public string Name;
        public static uint MaxCapacity;
        private Vehicle[] ParkedVehicles;
        // Only to read when instantiating a garage object
        // Todo: remove?
        public readonly uint Capacity;
        // Count all the spaces that are not empty
        public int Count => ParkedVehicles.Count(i => i != null);

        public bool IsFull => MaxCapacity <= Count;

        public Garage(string name, uint maxcapacity)
        {
            Name = name;
            MaxCapacity = maxcapacity;
            Capacity = maxcapacity;
            ParkedVehicles = new Vehicle[MaxCapacity];
        }

        internal void ListAllParkedVehicles()
        {
            Console.WriteLine("\nThe parked vehicles in the garage are: ");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ParkedVehicles[i].GetType().Name} - {ParkedVehicles[i].RegNumber}");
            }
        }

        internal void ListAmountAndVehicleType()
        {
            // https://stackoverflow.com/questions/1139181/a-method-to-count-occurrences-in-a-list
            // https://stackoverflow.com/questions/18527896/groupby-how-to-handle-empty-groups
            var grouping = ParkedVehicles.GroupBy(i => i?.GetType().Name);
            Console.WriteLine();

            foreach (var item in grouping)
            {
                Console.WriteLine("The garage contains {0} unit(s) of this type of vehicle: {1}", item.Count(), item.Key);
            }
        }

        internal bool ParkVehicle(Vehicle vehicle)
        {
            if (IsFull)
            {
                Console.WriteLine("The garage is full");
                return false;
            }
            else
            {
                Console.WriteLine("The garage is not full");
                // Find an index to place the vehicle and add it
                int index = Array.FindIndex(ParkedVehicles, i => i == null || String.IsNullOrEmpty(i.RegNumber));
                ParkedVehicles[index] = vehicle;

                Console.WriteLine("Used spaces " + Count);
                return true;
            }
        }

        internal bool UnparkVehicle(Vehicle vehicle)
        {

                        Array.Clear(ParkedVehicles, 1, 2);
                        ListAllParkedVehicles();
                        return true;
            // while (true)
            // {
            //     ListAllParkedVehicles();
            //     var input = Utils.AskForNumber("Which vehicle do you want to unpark? Please write a number");

            //     switch (input)
            //     {
            //         case 1:
            //             Array.Clear(ParkedVehicles, 1, 2);
            //             //ParkedVehicles[0] = null;
            //             ListAllParkedVehicles();
            //             break;
            //         default:
            //             break;
            //     }
            // }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in ParkedVehicles)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
