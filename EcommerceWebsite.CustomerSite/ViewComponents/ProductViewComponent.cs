using EcommerceWebsite.CustomerSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductClient _productApiClient;

        public ProductViewComponent(IProductClient productApiClient)
        {
            _productApiClient = productApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productApiClient.GetProducts();

            return View(products);
        }
    }
}
