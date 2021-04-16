using EcommerceWebsite.Backend.Data;
using EcommerceWebsite.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebsite.Backend.Models;

namespace EcommerceWebsite.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CategoriesVm>>> GetCategories()
        {
            return await _context.Categories
                .Select(x => new CategoriesVm { CategoryID = x.CategoryID, CategoryName = x.CategoryName, Description = x.Description })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<CategoriesVm>> GetCategorieById(int id)
        {
            var Categories = await _context.Categories.FindAsync(id);

            if (Categories == null)
            {
                return NotFound();
            }

            var CategoriesVm = new CategoriesVm
            {
                CategoryID = Categories.CategoryID,
                CategoryName = Categories.CategoryName,
                Description = Categories.Description
            };

            return CategoriesVm;
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> PutCategories(int id, CategoriesFormVm CategoriesFormVm)
        {
            var Categories = await _context.Categories.FindAsync(id);

            if (Categories == null)
            {
                return NotFound();
            }

            Categories.CategoryName = CategoriesFormVm.CategoryName;
            Categories.Description = CategoriesFormVm.Description;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<CategoriesVm>> PostCategories(CategoriesFormVm CategoriesFormVm)
        {
            var Categories = new Categories
            {
                CategoryName = CategoriesFormVm.CategoryName,
                Description = CategoriesFormVm.Description
            };

            _context.Categories.Add(Categories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategories", new { id = Categories.CategoryID }, new CategoriesVm { CategoryID = Categories.CategoryID, CategoryName = Categories.CategoryName, Description = Categories.Description });
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteCategories(int id)
        {
            var Categories = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryID == id);

            if (Categories == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(Categories);
            await _context.SaveChangesAsync();

            return Ok(Categories);
        }
    }
}
