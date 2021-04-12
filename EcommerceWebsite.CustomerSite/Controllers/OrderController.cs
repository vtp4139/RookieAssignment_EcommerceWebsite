using EcommerceWebsite.CustomerSite.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceWebsite.CustomerSite.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderClient _orderApiClient;
        private readonly IConfiguration _configuration;

        public OrderController(IOrderClient orderApiClient, IConfiguration configuration)
        {
            _orderApiClient = orderApiClient;
            _configuration = configuration;
        }

        public async Task<IActionResult> IndexAsync()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = await _orderApiClient.GetOrders(id);
           
            return View(orders);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var ListItem = await _orderApiClient.GetOrder(id);

            foreach (var x in ListItem)
            {
                for (int i = 0; i < x.ImageLocation.Count; i++)
                {
                    string setUrl = _configuration["BackendUrl:Default"] + x.ImageLocation[i];
                    x.ImageLocation[i] = setUrl;
                }
            }
            return View(ListItem);
        }
    }
}
