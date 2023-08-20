using hr_bot_webapp_v2.Data;
using RestSharp;
using Newtonsoft.Json;

namespace hr_bot_webapp_v2.Services
{
    public class IPGeoLocationService
    {
        private readonly RestClient _client = new("https://ip-geo-location.p.rapidapi.com");

        public async Task<IPGeoLocationResponse> GetLocation()
        {
            // Construct the query string for the request
            string queryString = "ip/check?format=json";

            // Create the RestRequest using the constructed query string
            var request = new RestRequest(queryString);
            request.AddHeader("X-RapidAPI-Key", "8cb9a4bbb6msh55366a547751823p11a181jsnbb394cbe39a0");
            request.AddHeader("X-RapidAPI-Host", "ip-geo-location.p.rapidapi.com");

            // Execute the request and deserialize the response content into IpGeoLocationResponse
            var response = await _client.ExecuteAsync(request);
            IPGeoLocationResponse locationData = JsonConvert.DeserializeObject<IPGeoLocationResponse>(response.Content);
            return locationData;
        }


    }
}
