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
            var productList = await _context.Products.Include(p => p.ImageFiles).ToListAsync();

            if (productList == null)
            {
                return NotFound();
            }

            List<ProductVm> productVmList = new List<ProductVm>();

            foreach (var x in productList)
            {
                ProductVm get = new ProductVm();
                get.ProductID = x.ProductID;
                get.ProductName = x.ProductName;
                get.Description = x.Description;
                get.Price = x.Price;
                get.CreatedDate = x.CreatedDate;
                get.UpdatedDate = x.UpdatedDate;
                get.ImageLocation = new List<string>();

                for (int i = 0; i < x.ImageFiles.Count; i++)
                {
                    get.ImageLocation.Add(x.ImageFiles.ElementAt(i).ImageLocation);
                }
                productVmList.Add(get);
            }
            return productVmList;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductVm>> GetProduct(int id)
        {
            var Product = await _context.Products.Include(p => p.ImageFiles).Include(p => p.Ratings).FirstOrDefaultAsync(x => x.ProductID == id);
            int _RatingCount = 0;
            double _RatingPoint = 0;

            if (Product == null)
            {
                return NotFound();
            }

            if(Product.Ratings != null)
            {
                _RatingCount = Product.Ratings.Count();
                if(_RatingCount > 0)
                    _RatingPoint = Product.Ratings.Average(r => r.RatingPoint);
            }

            var ProductVm = new ProductVm
            {
                ProductID = Product.ProductID,
                ProductName = Product.ProductName,
                Price = Product.Price,
                Description = Product.Description,
                CreatedDate = Product.CreatedDate,
                UpdatedDate = Product.UpdatedDate,
                //RatingCount = Product.Ratings.Count(),
                //RatingPoint = Product.Ratings.Average(r => r.RatingPoint),
                RatingCount = _RatingCount,
                RatingPoint = _RatingPoint,
                ImageLocation = new List<string>()
            };

            for (int i = 0; i < Product.ImageFiles.Count; i++)
            {
                ProductVm.ImageLocation.Add(Product.ImageFiles.ElementAt(i).ImageLocation);
            }

            return ProductVm;
        }

        [HttpGet("GetByCategory/{idCate}")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductVm>>> GetProductByCategory(int idCate)
        {
            var productList = await _context.Products
                .Include(p => p.ImageFiles)
                .Where(p => p.CategoryID == idCate)
                .ToListAsync();

            List<ProductVm> productVmList = new List<ProductVm>();

            foreach (var x in productList)
            {
                ProductVm get = new ProductVm();
                get.ProductID = x.ProductID;
                get.ProductName = x.ProductName;
                get.Description = x.Description;
                get.Price = x.Price;
                get.CreatedDate = x.CreatedDate;
                get.UpdatedDate = x.UpdatedDate;
                get.ImageLocation = new List<string>();

                for (int i = 0; i < x.ImageFiles.Count; i++)
                {
                    get.ImageLocation.Add(x.ImageFiles.ElementAt(i).ImageLocation);
                }
                productVmList.Add(get);
            }
            return productVmList;
        }

        [HttpPut("{id}")]
        [Authorize]
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
            //Products.CreatedDate = ProductsFormVm.CreatedDate;
            Products.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProductVm>> PostProduct(ProductFormVm ProductsFormVm)
        {
            var Products = new Product
            {
                ProductName = ProductsFormVm.ProductName,
                Description = ProductsFormVm.Description,
                Price = ProductsFormVm.Price,             
                CategoryID = ProductsFormVm.CategoryID,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };

            _context.Products.Add(Products);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = Products.ProductID }, new ProductVm { ProductName = Products.ProductName, Description = Products.Description, Price = Products.Price, CreatedDate = Products.CreatedDate, UpdatedDate = Products.UpdatedDate });
        }

        [HttpDelete("{id}")]
        [Authorize]
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
