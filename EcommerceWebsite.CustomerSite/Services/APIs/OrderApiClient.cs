using EcommerceWebsite.CustomerSite.Services.Interfaces;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.APIs
{
    public class OrderApiClient : IOrderClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IRequest _request;

        public OrderApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IRequest request)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _request = request;
        }

        public async Task<IList<CartItemsVm>> GetOrder(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Order/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<CartItemsVm>>();
        }

        public async Task<IList<OrderVm>> GetOrders(string idUser)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/Order?idUser=" + idUser);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<OrderVm>>();
        }

        public async Task<OrderVm> PostOrders(List<CartItemsVm> ListItem)
        {
            var client = _request.SendAccessToken().Result;

            //Send json with body
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(ListItem),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/Order", httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<OrderVm>();
        }

        public async Task<bool> DeleteOrders(int id)
        {
            var client = _request.SendAccessToken().Result;

            //Send json with body
            var response = await client.DeleteAsync(_configuration["BackendUrl:Default"] + "/api/Order/" + id);

            response.EnsureSuccessStatusCode();
            return true;
        }

    }
}
