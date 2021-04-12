﻿using EcommerceWebsite.CustomerSite.Services.Interfaces;
using EcommerceWebsite.Shared;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Services.APIs
{
    public class OrderApiClient : IOrderClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OrderApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
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
            //Send access token 
            var client = _httpClientFactory.CreateClient();
            var accessToken = await _httpContextAccessor.HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);
            client.SetBearerToken(accessToken);

            //Send json with body
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(ListItem),
                Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_configuration["BackendUrl:Default"] + "/api/Order", httpContent);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<OrderVm>();
        }
    }
}
