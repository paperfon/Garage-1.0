using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage_1._0
{
    //     static class ArrayExtensions
    // {
    //     public static int IndexOf<T>(this T[] array, T value)
    //     {
    //         return Array.IndexOf(array, value);
    //     }   
    // }
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

        // Internal subclass for exporting the parked vehicle collection to the UI
        internal class ExportParkedVehicles
        {
            internal int ParkingSpot { get; set; }
            internal string TypeOfVehicle { get; set; }
            internal string RegNumber { get; set; }
        }

        internal IEnumerable<ExportParkedVehicles> ListAllParkedVehicles()
        {
            var result = ParkedVehicles
            .Where(v => v != null)
            .Select(v => new ExportParkedVehicles
            {
                ParkingSpot = Array.IndexOf(ParkedVehicles, v) + 1,
                TypeOfVehicle = v.GetType().Name,
                RegNumber = v.RegNumber
            });

            return result;
        }

        internal IEnumerable<IGrouping<string, Vehicle>> ListAmountAndVehicleType()
        {
            // Todo: Check/Test the methods with empty values
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
            // Todo: What if trying to unpark an unexisting vehicle?
            int index = Array.FindIndex(ParkedVehicles, i => i.RegNumber.ToLower() == regnumber.ToLower());
            ParkedVehicles[index] = null;
            return true;
        }

        internal bool FindVehicleOnRegnumber(string regnumber)
        {
            // Todo: This returns a bool but what if there are multiples vehicles with the same RegNumber due to some user error while input or should the app check this too?

            // var q = from v in ParkedVehicles
            //        where v != null && v.RegNumber.ToLower() == regnumber.ToLower()
            //        select v;
            // if (q == null) { return false; }
            // return true;

            if (!Array.Exists(ParkedVehicles, i => i.RegNumber.ToLower() == regnumber.ToLower())) { return false; }
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
