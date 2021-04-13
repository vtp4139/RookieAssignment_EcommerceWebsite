using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using EcommerceWebsite.Backend.Data;
using EcommerceWebsite.Shared;
using EcommerceWebsite.Backend.Controllers;
using EcommerceWebsite.Backend.Models;

namespace EcommerceWebsite.Backend.UnitTest
{
    public class CategoriesControllerTests : IDisposable
    {
        private SqliteConnection _connection;
        private ApplicationDbContext _dbContext;
            
        public CategoriesControllerTests()
        {
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(_connection)
                .Options;
            _dbContext = new ApplicationDbContext(options);
            _dbContext.Database.EnsureCreated();
        }

        public void Dispose()
        {
            _connection.Close();
        }

        [Fact]
        public async Task PostCategory_Success()
        {
            var category = new CategoriesFormVm 
            {
             CategoryName = "Ghế gaming",
             Description = "Ghế gaming chính hãng, uy tín"
            };

            var controller = new CategoriesController(_dbContext);
            var result = await controller.PostCategories(category);

            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            var returnValue = Assert.IsType<CategoriesVm>(createdAtActionResult.Value);
            Assert.Equal("Ghế gaming", returnValue.CategoryName);
            Assert.Equal("Ghế gaming chính hãng, uy tín", returnValue.Description);
        }

        [Fact]
        public async Task GetCategory_Success()
        {
            _dbContext.Categories.Add(new Categories {
                CategoryName = "Ghế gaming",
                Description = "Ghế gaming chính hãng, uy tín"
            });
            await _dbContext.SaveChangesAsync();

            var controller = new CategoriesController(_dbContext);
            var result = await controller.GetCategories();

            var actionResult = Assert.IsType<ActionResult<IEnumerable<CategoriesVm>>>(result);
            Assert.NotEmpty(actionResult.Value);
        }
    }
}
