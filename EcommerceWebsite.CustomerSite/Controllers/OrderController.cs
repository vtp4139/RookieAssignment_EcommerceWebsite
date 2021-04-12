using EcommerceWebsite.CustomerSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderClient _orderApiClient;

        public OrderController(IOrderClient orderApiClient)
        {
            _orderApiClient = orderApiClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var orders = await _orderApiClient.GetOrders();
           
            return View(orders);
        }
    }
}
