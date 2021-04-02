using EcommerceWebsite.Backend.Data;
using EcommerceWebsite.Backend.Models;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebsite.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductVm>>> GetProducts()
        {
            return await _context.Products
                .Select(x => new ProductVm 
                { 
                    ProductID = x.ProductID, 
                    ProductName = x.ProductName, 
                    Description = x.Description, 
                    Price = x.Price, 
                    CreatedDate = x.CreatedDate, 
                    UpdatedDate = x.UpdatedDate 
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductVm>> GetProduct(int id)
        {
            var Products = await _context.Products.FindAsync(id);

            if (Products == null)
            {
                return NotFound();
            }

            var ProductVm = new ProductVm
            {
                ProductID = Products.ProductID,
                ProductName = Products.ProductName,
                Description = Products.Description,
                CreatedDate = Products.CreatedDate,
                UpdatedDate = Products.UpdatedDate
            };

            return ProductVm;
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> PutProducts(int id, ProductFormVm ProductsFormVm)
        {
            var Products = await _context.Products.FindAsync(id);

            if (Products == null)
            {
                return NotFound();
            }

            Products.ProductName = ProductsFormVm.ProductName;
            Products.Description = ProductsFormVm.Description;
            Products.Price = ProductsFormVm.Price;
            Products.CreatedDate = ProductsFormVm.CreatedDate;
            Products.UpdatedDate = ProductsFormVm.UpdatedDate;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<ProductVm>> PostProduct(ProductFormVm ProductsFormVm)
        {
            var Products = new Product
            {
                ProductName = ProductsFormVm.ProductName,
                Description = ProductsFormVm.Description,
                Price = ProductsFormVm.Price,
                CreatedDate = ProductsFormVm.CreatedDate,
                UpdatedDate = ProductsFormVm.UpdatedDate,
                CategoryID = ProductsFormVm.CategoryID
            };

            _context.Products.Add(Products);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = Products.ProductID }, new ProductVm { ProductName = Products.ProductName, Description = Products.Description, Price = Products.Price, CreatedDate = Products.CreatedDate, UpdatedDate = Products.UpdatedDate });
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var Products = await _context.Products.FirstOrDefaultAsync(x => x.ProductID == id);

            if (Products == null)
            {
                return NotFound();
            }

            _context.Products.Remove(Products);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
