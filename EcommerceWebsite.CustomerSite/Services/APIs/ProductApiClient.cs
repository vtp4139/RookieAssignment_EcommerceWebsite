using EcommerceWebsite.CustomerSite.Services.Interfaces;
using EcommerceWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;

namespace EcommerceWebsite.CustomerSite.Services.APIs
{
    public class ProductApiClient : IProductClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }


        public async Task<ProductVm> GetProduct(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/product/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ProductVm>();
        }

        public async Task<IList<ProductVm>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/product");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ProductVm>>();
        }

        public async Task<IList<ProductVm>> GetProductByCategory(int idCate)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/product/GetByCategory/" + idCate);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ProductVm>>();
        }
    }
}
