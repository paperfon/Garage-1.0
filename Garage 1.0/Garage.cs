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

        internal Vehicle[] ListAllParkedVehicles()
        {
            Vehicle[] parkedVehiclesClone = ParkedVehicles.Clone() as Vehicle[];
            return parkedVehiclesClone;
        }

        internal IEnumerable<IGrouping<string, Vehicle>> ListAmountAndVehicleType()
        {
            var grouping = ParkedVehicles.GroupBy(i => i?.GetType().Name);
            return grouping;
        }

        internal bool ParkVehicle(Vehicle vehicle)
        {
            if (IsFull) return false;
            // Find an index to park the vehicle (if index is null or there is no regnumber property)
            int index = Array.FindIndex(ParkedVehicles, i => i == null || String.IsNullOrEmpty(i.RegNumber));
            ParkedVehicles[index] = vehicle;
            return true;
        }

        internal bool UnparkVehicle(string regnumber)
        {
            int index = Array.FindIndex(ParkedVehicles, i => i.RegNumber.ToLower() == regnumber.ToLower());
            Console.WriteLine(index);
            ParkedVehicles[index] = null;
            return true;
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
