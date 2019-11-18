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

        // Internal subclass for exporting the parked vehicle collection to the UI
        internal class ExportedListOfVehicles
        {
            internal string Fabricant { get; set; }
            internal uint NumberOfWheels { get; set; }
            internal string Color { get; set; }
            internal uint ProductionYear { get; set; }
            internal int ParkingSpot { get; set; }
            internal string TypeOfVehicle { get; set; }
            internal string RegNumber { get; set; }
        }

        internal IEnumerable<ExportedListOfVehicles> ListParkedVehicles()
        {
            var result = ParkedVehicles
            .Where(v => v != null)
            .Select(v => new ExportedListOfVehicles
            {
                ParkingSpot = Array.IndexOf(ParkedVehicles, v) + 1,
                TypeOfVehicle = v.GetType().Name,
                RegNumber = v.RegNumber,
                Fabricant = v.Fabricant,
                NumberOfWheels = v.NumberOfWheels,
                Color = v.Color,
                ProductionYear = v.ProductionYear
            });

            return result;
        }

        internal IEnumerable<IGrouping<string, Vehicle>> ListVehicleTypes()
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
            int index = Array.FindIndex(ParkedVehicles, i => i!= null && i.RegNumber.ToLower() == regnumber.ToLower());

            if (index >= 0)
            {
                ParkedVehicles[index] = null;
                return true;
            }

            return false;
        }

        internal bool FindVehicleOnRegnumber(string regnumber)
        {
            // Todo: This returns a bool but what if there are multiples vehicles with the same RegNumber due to some user error while input or should the app check this too?

            var matchedVehicle = ParkedVehicles.FirstOrDefault(v => v != null && v.RegNumber.ToLower() == regnumber.ToLower());

            if (matchedVehicle != null)
            {
                return true;
            }
            return false;
        }

        internal IEnumerable<ExportedListOfVehicles> FindVehicleOnProperties(string fabricant, uint numberofwheels, string color, uint productionyear)
        {
            var result = ListParkedVehicles();

            if (!String.IsNullOrEmpty(fabricant))
            {
                result = result.Where(i => i.Fabricant == fabricant);
            }

            if (numberofwheels != 0)
            {
                result = result.Where(i => i.NumberOfWheels == numberofwheels);
            }

            if (!String.IsNullOrEmpty(color))
            {
                result = result.Where(i => i.Color == color);
            }

            if (productionyear != 0)
            {
                result = result.Where(i => i.ProductionYear == productionyear);
            }   

            return result;
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
