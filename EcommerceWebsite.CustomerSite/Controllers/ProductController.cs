using EcommerceWebsite.CustomerSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductClient _productApiClient;

        public ProductController(IProductClient productApiClient)
        {
            _productApiClient = productApiClient;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var products = await _productApiClient.GetProducts();

            foreach(var x in products)
            {
                foreach (var y in x.ImageLocation)
                {
                    
                }

            }

            return View(products);
        }
    }
}
