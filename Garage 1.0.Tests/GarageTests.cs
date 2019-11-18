using System;
using Xunit;

namespace Garage_1._0.Tests
{
    public class GarageTests
    {
        [Fact]
        public void Garage_NewInstance()
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
    }
}
