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
            var garage = new Garage<Vehicle>("My Sharona", 20);

            // Act
            var expectedName = "Mi garaje";
            uint expectedCapacity = 20;

            // Assert
            Assert.Equal(expectedName, garage.Name);
            Assert.Equal(expectedCapacity, garage.Capacity);
        }

        [Fact]
        public void Sum()
        {
            var test = new Sum();
            test.SumMethod(2, 2);

            var result = 4;

            Assert.Equal(result, test.APlusB);
        }
    }
}
