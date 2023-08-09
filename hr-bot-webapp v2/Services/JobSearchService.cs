using hr_bot_webapp_v2.Data;
using RestSharp;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace hr_bot_webapp_v2.Services
{
    public class JobSearchService
    {
        private readonly RestClient _client;

        public JobSearchService()
        {
            _client = new RestClient("https://jsearch.p.rapidapi.com");
        }

        public async Task<JobSearchResponse> SearchJobs(string position, string location, int page, int num_pages)
        {
            // Encode the position and location parameters for the query string
            string encodedPosition = Uri.EscapeDataString(position);
            string encodedLocation = Uri.EscapeDataString(location);

            // Construct the query string based on the search variables
            string queryString = $"search?query={encodedPosition}%20in%20{encodedLocation}&page={page}&num_pages={num_pages}";

            // Create the RestRequest using the constructed query string
            var request = new RestRequest(queryString);
            request.AddHeader("X-RapidAPI-Key", "8cb9a4bbb6msh55366a547751823p11a181jsnbb394cbe39a0");
            request.AddHeader("X-RapidAPI-Host", "jsearch.p.rapidapi.com");

            // Execute the request and deserialize the response content into JobSearchResponse
            var response = await _client.ExecuteAsync(request);
            JobSearchResponse jobData = JsonConvert.DeserializeObject<JobSearchResponse>(response.Content);

            return jobData;
        }

    }
}