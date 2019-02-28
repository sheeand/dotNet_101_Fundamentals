using System;
using _03_Defining_Classes_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_2_Unit_Tests
{
    [TestClass]
    public class WeatherRepositoryTests
    {
        // Field
        private Weather _weather;
        private WeatherRepository _weatherRepo; // The list of Weather is included in the initialization

        // TestInit
        [TestInitialize]
        public void Arrange()
        {
            // Arrange

            _weatherRepo = new WeatherRepository();

            _weather = new Weather
            {
                WeatherID = 1,
                IsPrecipitating = true,
                WindSpeed = 30,
                WindDirection = WindDirection.East,
                Temperature = 55,
                WeatherDate = DateTimeOffset.Now
            };

            _weatherRepo.AddWeatherItemToList(_weather);

        }

        [TestMethod]
        public void WeatherRepo_NumberOfItemsInList_IsCorrectInt()
        {
            // Act
            var expected = 1;
            var actual = _weatherRepo.GetWeatherList().Count;

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
