using EcommerceWebsite.Backend.Data;
using EcommerceWebsite.Backend.Models;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ProductVm>>> GetProducts()
        {
            var productList = await _context.Products.Include(p => p.ImageFiles).Include(p => p.Categories).ToListAsync();

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
                get.CategoryName = x.Categories.CategoryName;
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
            var Product = await _context.Products.Include(p => p.ImageFiles).Include(p => p.Ratings).Include(p => p.Categories).FirstOrDefaultAsync(x => x.ProductID == id);
            int _RatingCount = 0;
            double _RatingPoint = 0;

            if (Product == null)
            {
                return NotFound();
            }

            if (Product.Ratings != null)
            {
                _RatingCount = Product.Ratings.Count();
                if (_RatingCount > 0)
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
                CategoryName = Product.Categories.CategoryName,
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
        public async Task<IActionResult> PutProducts(int id, [FromForm] ProductFormVm ProductsFormVm)
        {
            var Products = await _context.Products.FindAsync(id);

            if (Products == null)
            {
                return NotFound();
            }

            Products.ProductName = ProductsFormVm.ProductName;
            Products.Description = ProductsFormVm.Description;
            Products.Price = ProductsFormVm.Price;
            Products.UpdatedDate = DateTime.Now;
            Products.CategoryID = ProductsFormVm.CategoryID;

            await _context.SaveChangesAsync();

            //Add image 
            if ((ProductsFormVm.Images != null) && (ProductsFormVm.Images.Count > 0))
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                foreach (IFormFile file in ProductsFormVm.Images)
                {
                    string fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    ImageFile nFile = new ImageFile();
                    nFile.ImageLocation = $"/images/{fileName}";
                    nFile.UploadedTime = DateTime.Now;
                    nFile.ProductID = Products.ProductID;

                    _context.ImageFiles.Add(nFile);
                    await _context.SaveChangesAsync();
                }
            }

            return NoContent();
        }

        [HttpDelete("DeleteImages/{imageLocation}")]
        [Authorize]
        public async Task<IActionResult> DeleteImages(string imageLocation)
        {
            //string str = imageLocation.Replace("_", "/");
            string str = "/images/" + imageLocation;
            var Image = await _context.ImageFiles.FirstOrDefaultAsync(x => x.ImageLocation == str);

            if (Image == null)
            {
                return NotFound();
            }

            _context.ImageFiles.Remove(Image);
            await _context.SaveChangesAsync();

            string fileName = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            string[] temp = str.Split("/");
            fileName = Path.Combine(fileName, temp[2].ToString());

            if (System.IO.File.Exists(fileName))
            {
                System.IO.File.Delete(fileName);
            }

            return NoContent();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProductVm>> PostProduct([FromForm] ProductFormVm ProductsFormVm)
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

            //Add image 
            if ((ProductsFormVm.Images != null) && (ProductsFormVm.Images.Count > 0))
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                foreach (IFormFile file in ProductsFormVm.Images)
                {
                    string fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    ImageFile nFile = new ImageFile();
                    nFile.ImageLocation = $"/images/{fileName}";
                    nFile.UploadedTime = DateTime.Now;
                    nFile.ProductID = Products.ProductID;

                    _context.ImageFiles.Add(nFile);
                    await _context.SaveChangesAsync();
                }
            }

            return CreatedAtAction("GetProducts", new { id = Products.ProductID }, new ProductVm { ProductName = Products.ProductName, Description = Products.Description, Price = Products.Price, CreatedDate = Products.CreatedDate, UpdatedDate = Products.UpdatedDate });
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var Products = await _context.Products.Include(p => p.OrderDetails).Include(p => p.ImageFiles).FirstOrDefaultAsync(x => x.ProductID == id);

            if (Products == null)
            {
                return NotFound();
            }
            else if(Products.OrderDetails.Count > 0)
            {
                return NoContent();
            }

            if (Products.ImageFiles != null && Products.ImageFiles.Count() > 0)
            {
                foreach (var imgFile in Products.ImageFiles)
                {
                    string fileName = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                    string[] temp = imgFile.ImageLocation.Split("/");
                    fileName = Path.Combine(fileName, temp[2].ToString());

                    if (System.IO.File.Exists(fileName))
                    {
                        System.IO.File.Delete(fileName);
                    }
                }
            }
            _context.Products.Remove(Products);
            await _context.SaveChangesAsync();

            return Ok(Products);
        }
    }
}
