using Newtonsoft.Json;
using System;

namespace ApiWeatherTests.ResponseModels.Location
{
    public class ConsolidatedWeatherModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "applicable_date")]
        public DateTime ApplicableDate { get; set; }
        [JsonProperty(PropertyName = "weather_state_name")]
        public string WeatherStateName { get; set; }
        [JsonProperty(PropertyName = "weather_state_abbr")]
        public string WeatherStateAbbr { get; set; }
        [JsonProperty(PropertyName = "wind_speed")]
        public double? WindSpeed { get; set; }
        [JsonProperty(PropertyName = "wind_direction")]
        public double? WindDirection { get; set; }
        [JsonProperty(PropertyName = "wind_direction_compass")]
        public string WindDirectionCompass { get; set; }
        [JsonProperty(PropertyName = "min_temp")]
        public double? MinTemperature { get; set; }
        [JsonProperty(PropertyName = "max_temp")]
        public double? MaxTemperature { get; set; }
        [JsonProperty(PropertyName = "the_temp")]
        public double? Temperature { get; set; }
        [JsonProperty(PropertyName = "air_pressure")]
        public double? AirPressure { get; set; }
        [JsonProperty(PropertyName = "humidity")]
        public double? Humidity { get; set; }
        [JsonProperty(PropertyName = "visibility")]
        public double? Visibility { get; set; }
        [JsonProperty(PropertyName = "predictability")]
        public int? Predictability { get; set; }
    }
}
