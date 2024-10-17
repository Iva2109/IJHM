using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJHM.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit_ShouldReturnCorrectValue()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 0;

            // Act
            double result = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_ShouldReturnCorrectValue()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 32;

            // Act
            double result = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
