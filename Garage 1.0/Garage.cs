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
            // todo: what if trying to unpark an unexisting vehicle?
            int index = Array.FindIndex(ParkedVehicles, i => i.RegNumber.ToLower() == regnumber.ToLower());
            ParkedVehicles[index] = null;
            return true;
        }

        internal bool FindVehicleOnRegnumber(string regnumber)
        {
            Console.WriteLine("Finding a vehicle");
            //bool found = Array.Exists(ParkedVehicles, i => i.RegNumber.ToLower() == regnumber.ToLower());
            //if (!Array.Exists(ParkedVehicles, i => i.RegNumber.ToLower() == regnumber.ToLower())) { return false; }
            //var q = from v in ParkedVehicles
            //        where v.RegNumber.ToLower() == regnumber.ToLower()
            //        select v;

            var q = ParkedVehicles
                .Where(v => v.RegNumber.ToLower() == regnumber.ToLower());
            foreach (var item in q)
            {   
                Console.WriteLine("foreach loop " + item);
            }
            if (q == null)
            {
                return false;
            }
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
