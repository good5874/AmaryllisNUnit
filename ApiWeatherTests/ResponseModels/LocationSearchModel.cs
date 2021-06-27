using Newtonsoft.Json;

namespace ApiWeatherTests.ResponseModels
{
    public class LocationSearchModel
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "location_type")]
        public string LocationType { get; set; }
        [JsonProperty(PropertyName = "latt_long")]
        public string LattLong { get; set; }
        [JsonProperty(PropertyName = "woeid")]
        public int Woeid { get; set; }
        [JsonProperty(PropertyName = "distance")]
        public int Distance { get; set; }
    }
}
