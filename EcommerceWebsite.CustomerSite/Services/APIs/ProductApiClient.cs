using EcommerceWebsite.CustomerSite.Services.Interfaces;
using EcommerceWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace EcommerceWebsite.CustomerSite.Services.APIs
{
    public class ProductApiClient : IProductClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<ProductVm> GetProduct(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44360/products/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ProductVm>();
        }

        public async Task<IList<ProductVm>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:44360/products");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IList<ProductVm>>();
        }

        //public Task<ProductVm> PostProduct()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ProductVm> PutProduct()
        //{
        //    throw new NotImplementedException();
        //}
        //public Task<ProductVm> DeleteProduct()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
