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
    }
}
