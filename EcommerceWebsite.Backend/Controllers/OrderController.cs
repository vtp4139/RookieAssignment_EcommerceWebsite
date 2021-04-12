using EcommerceWebsite.Backend.Data;
using EcommerceWebsite.Backend.Models;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcommerceWebsite.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IList<OrderVm>>> GetOrders(string idUser)
        {
            return await _context.Orders.Where(o => o.Users.Id == idUser)
                .Select(x => new OrderVm
                {
                    OrderID = x.OrderID,
                    OrderDate = x.OrderDate
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<IList<CartItemsVm>>> GetOrder(int id)
        {         
            var Order = await _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Product).ThenInclude(p => p.ImageFiles).FirstOrDefaultAsync(o => o.OrderID == id);

            if (Order == null)
            {
                return NotFound();
            }

            List<CartItemsVm> listItem = new List<CartItemsVm>();
            CartItemsVm cartitem = new CartItemsVm();
            foreach(OrderDetail x in Order.OrderDetails)
            {
                cartitem.ProductName = x.Product.ProductName;
                cartitem.Price = x.UnitPrice;
                cartitem.Quantity = x.Quantity;
                cartitem.ImageLocation = new List<string>();
                for (int i = 0; i < x.Product.ImageFiles.Count; i++)
                {
                    cartitem.ImageLocation.Add(x.Product.ImageFiles.ElementAt(i).ImageLocation);
                }
                listItem.Add(cartitem);
            }

            return listItem;
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> PutOrders(int id, OrderFormVm OrdersFormVm)
        {
            var Orders = await _context.Orders.FindAsync(id);

            if (Orders == null)
            {
                return NotFound();
            }

            Orders.OrderDate = OrdersFormVm.OrderDate;
            Orders.UserId = OrdersFormVm.UserId;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<OrderVm>> PostOrders(List<CartItemsVm> ListItem)
        {
            //Add order
            var Orders = new Order
            {
                OrderDate = DateTime.Now,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
            };
            _context.Orders.Add(Orders);
            await _context.SaveChangesAsync();

            //Add order details
            OrderDetail x = new OrderDetail();
            foreach (CartItemsVm item in ListItem)
            {
                x.OrderID = Orders.OrderID;
                x.ProductID = item.ProductID;
                x.Quantity = item.Quantity;
                x.UnitPrice = item.Price;

                _context.OrderDetails.Add(x);
                await _context.SaveChangesAsync();
            }
            await _context.Orders.FindAsync(Orders);
            return CreatedAtAction("GetOrders", new { id = Orders.OrderID }, new OrderVm { OrderDate = Orders.OrderDate});
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOrders(int id)
        {
            var Orders = await _context.Orders.FirstOrDefaultAsync(x => x.OrderID == id);

            if (Orders == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(Orders);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
