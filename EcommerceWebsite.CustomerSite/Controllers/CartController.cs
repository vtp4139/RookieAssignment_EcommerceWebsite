using EcommerceWebsite.CustomerSite.Services;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            List<CartItemsVm> ListPro = HttpContext.Session.Get<List<CartItemsVm>>("SessionCart");
            return View(ListPro);
        }
    }
}
