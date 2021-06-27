using ApiWeatherTests.ResponseModels;
using ApiWeatherTests.ResponseModels.Location;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleClient
{
    public class Client
    {
        private string url = "https://www.metaweather.com/api/location/";

        public async Task<List<LocationSearchModel>> LocationSearch(string searchString)
        {
            string path = $"search/?query={searchString}";
            return await SendRequest<List<LocationSearchModel>>(url + path);
        }

        public async Task<LocationModel> GetLocation(string woeid)
        {
            string path = $"{woeid}";
            return await SendRequest<LocationModel>(url + path);
        }

        public async Task<List<ConsolidatedWeatherModel>> GetWeathersByDate(string woeid, string date)
        {
            string path = $"{woeid}/{date}/";
            return await SendRequest<List<ConsolidatedWeatherModel>>(url + path);
        }

        private async Task<T> SendRequest<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(result);
            }
        }
    }
}