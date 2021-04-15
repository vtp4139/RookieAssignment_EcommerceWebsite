using EcommerceWebsite.CustomerSite.Services.Interfaces;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.APIs
{
    public class RatingApiClient : IRatingClient
    {
        private readonly IConfiguration _configuration;
        private readonly IRequest _request;

        public RatingApiClient(IConfiguration configuration, IRequest request)
        {
            _configuration = configuration;
            _request = request;
        }

        public async Task<RatingVm> PostRating(RatingFormVm RatingFormVm)
        {
            var client = _request.SendAccessToken().Result;

            //Send json with body
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(RatingFormVm),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/Rating", httpContent);
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<RatingVm>();
        }
    }
}
