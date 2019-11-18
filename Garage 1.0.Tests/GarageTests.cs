using System;
using Xunit;

namespace Garage_1._0.Tests
{
    public class GarageTests
    {
        [Fact]
        public void Garage_NewInstance_CreatedWithNameAndCapacity()
        {
            // Arrange
            var expectedName = "My Sharona";
            uint expectedCapacity = 20;
            var garage = new Garage<Vehicle>(expectedName, expectedCapacity);

            // Act
            var actualName = garage.Name;
            var actualCapacity = garage.Capacity;

            // Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedCapacity, actualCapacity);
        }

        [Fact]
        public void ListParkVehicles_WhenEmpty_ReturnsNull()
        {
            //var expected = (string[])null;
            //Vehicle[] expected = null;
            // https://stackoverflow.com/questions/6802573/interfaces-whats-the-point
            var handler = new GarageHandler();
            var garage = new Garage<Vehicle>("Abcd", 4);

            handler.ListParkedVehicles(garage);
        }
    }
}
