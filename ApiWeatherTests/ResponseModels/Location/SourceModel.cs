using Newtonsoft.Json;

namespace ApiWeatherTests.ResponseModels.Location
{
    public class SourceModel
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
