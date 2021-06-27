using ApiWeatherTests.Extension;
using ConsoleClient;
using System.Collections.Generic;
using NUnit.Framework;
using ApiWeatherTests.ResponseModels;
using System.Linq;
using ApiWeatherTests.ResponseModels.Location;
using ApiWeatherTests.Enum;
using System;

namespace ApiWeatherTests
{
    public class Tests
    {
        private List<LocationSearchModel> cities;
        private LocationSearchModel city;
        private LocationModel location;
        private List<ConsolidatedWeatherModel> consolidatedWeather5YearsAgo;
        private Client client;

        [OneTimeSetUp]
        public void Setup()
        {
            client = new Client();
            cities = client.LocationSearch("min").Result;
            city = cities.FirstOrDefault(e => e.Title.ToLower().Contains("minsk"));
            location = client.GetLocation(city.Woeid.ToString()).Result;
            consolidatedWeather5YearsAgo = client
                .GetWeathersByDate(
                    city.Woeid.ToString(),
                    DateTime.Now.GetDateYearsAgo(5)).Result;
        }

        [Test]
        public void IsNotNullCities()
        {
            Assert.IsNotNull(cities);
        }

        [Test]
        public void IsNotNullCity()
        {
            Assert.IsNotNull(city);
        }

        [Test]
        public void IsNotNullLocation()
        {
            Assert.IsNotNull(location);
        }

        [Test]
        public void IsNotNullConsolidatedWeather5YearsAgo()
        {
            Assert.IsNotNull(consolidatedWeather5YearsAgo);
        }

        [Test]
        public void CheckGeodata()
        {
            Assert.AreEqual(city.LattLong, "53.90255,27.563101");
        }

        [Test]
        public void CheckTemperature()
        {
            var season = location.DateTime.GetSeason();
            var temperatures = location.Weathers.Select(x => x.Temperature);

            foreach (var temp in temperatures)
            {
                switch (season)
                {
                    case SeasonsEnum.Summer:
                        Assert.Positive(temp.Value);
                        break;

                    case SeasonsEnum.Autumn:
                        Assert.Pass();
                        break;

                    case SeasonsEnum.Winter:
                        Assert.Negative(temp.Value);
                        break;

                    case SeasonsEnum.Spring:
                        Assert.Pass();
                        break;
                }
            }
        }

        [Test]
        public void HasWeatherStateName()
        {
            if (consolidatedWeather5YearsAgo.Count() == 0)
            {
                Assert.Warn("Пусто:)");
                return;
            }

            foreach (var weather in consolidatedWeather5YearsAgo)
            {
                if (string.IsNullOrEmpty(weather.WeatherStateName) &&
                    DateTime.Now.Day == weather.ApplicableDate.Day &&
                    DateTime.Now.Month == weather.ApplicableDate.Month)
                {
                    Assert.Pass();
                    return;
                }
            }
        }
    }
}