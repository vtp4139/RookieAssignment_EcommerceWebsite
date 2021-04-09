using EcommerceWebsite.CustomerSite.Services;
using EcommerceWebsite.CustomerSite.Services.Interfaces;
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
        private readonly IOrderClient _orderApiClient;

        public CartController(IOrderClient orderApiClient)
        {
            _orderApiClient = orderApiClient;
        }

        public IActionResult Index()
        {
            List<CartItemsVm> ListPro = HttpContext.Session.Get<List<CartItemsVm>>("SessionCart");
            return View(ListPro);
        }

        public IActionResult Notify()
        {
            return View();
        }

        public IActionResult Remove(int id)
        {
            List<CartItemsVm> ListPro = HttpContext.Session.Get<List<CartItemsVm>>("SessionCart");

            CartItemsVm itemDel = new CartItemsVm();

            foreach(CartItemsVm item in ListPro)
            {
                if (item.ProductID == id)
                {
                    itemDel = item;
                    break;
                }               
            }

            ListPro.Remove(itemDel);
            HttpContext.Session.Set("SessionCart", ListPro);
            return RedirectToAction("Index");
        }

        public IActionResult PostOrder()
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction(actionName: "SignIn", controllerName: "Account");

            List<CartItemsVm> ListPro = HttpContext.Session.Get<List<CartItemsVm>>("SessionCart");
            _orderApiClient.PostOrders(ListPro);

            ListPro.Clear();
            HttpContext.Session.Set("SessionCart", ListPro);
            return RedirectToAction("Notify");
        }
    }
}
