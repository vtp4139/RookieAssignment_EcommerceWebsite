using EcommerceWebsite.CustomerSite.Services.Interfaces;
using EcommerceWebsite.Shared;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.APIs
{
    public class CategoryApiClient : ICategoryClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public CategoryApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<IList<CategoriesVm>> GetCategories()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/categories");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<CategoriesVm>>();
        }
        
        public async Task<CategoriesVm> GetCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration["BackendUrl:Default"] + "/api/categories/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<CategoriesVm>();
        }
    }
}
