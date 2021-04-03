using EcommerceWebsite.CustomerSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductClient _productApiClient;
        private readonly IConfiguration _configuration;

        public ProductController(IProductClient productApiClient, IConfiguration configuration)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var products = await _productApiClient.GetProducts();

            foreach(var x in products)
            {
                for(int i = 0; i < x.ImageLocation.Count; i++)
                {
                    string setUrl = _configuration["BackendUrl:Default"] + x.ImageLocation[i];
                    x.ImageLocation[i] = setUrl;
                }

            }
            return View(products);
        }
    }
}
