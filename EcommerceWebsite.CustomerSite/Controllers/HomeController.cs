using EcommerceWebsite.CustomerSite.Models;
using EcommerceWebsite.CustomerSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductClient _productApiClient;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IProductClient productApiClient, IConfiguration configuration)
        {
            _logger = logger;
            _productApiClient = productApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var products = await _productApiClient.GetProducts();

            foreach (var x in products)
            {
                for (int i = 0; i < x.ImageLocation.Count; i++)
                {
                    string setUrl = _configuration["BackendUrl:Default"] + x.ImageLocation[i];
                    x.ImageLocation[i] = setUrl;
                }

            }
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
