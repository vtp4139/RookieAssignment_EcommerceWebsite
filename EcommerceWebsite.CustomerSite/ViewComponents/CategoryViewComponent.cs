using EcommerceWebsite.CustomerSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryClient _categoryApiClient;

        public CategoryViewComponent(ICategoryClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var category = await _categoryApiClient.GetCategories();

            return View(category);
        }
    }
}
