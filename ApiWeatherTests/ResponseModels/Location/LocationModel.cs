using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ApiWeatherTests.ResponseModels.Location
{
    public class LocationModel
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "location_type")]
        public string LocationType { get; set; }
        [JsonProperty(PropertyName = "latt_long")]
        public string LattLong { get; set; }
        [JsonProperty(PropertyName = "time")]
        public DateTime DateTime { get; set; }
        [JsonProperty(PropertyName = "sun_rise")]
        public DateTime SunRise { get; set; }
        [JsonProperty(PropertyName = "sun_set")]
        public DateTime SunSet { get; set; }
        [JsonProperty(PropertyName = "timezone_name")]
        public string TimezoneName { get; set; }



        [JsonProperty(PropertyName = "parent")]
        public ParentModel Parent { get; set; }
        [JsonProperty(PropertyName = "consolidated_weather")]
        public List<ConsolidatedWeatherModel> Weathers { get; set; }
        [JsonProperty(PropertyName = "sources")]
        public List<SourceModel> Sources { get; set; }
    }
}
