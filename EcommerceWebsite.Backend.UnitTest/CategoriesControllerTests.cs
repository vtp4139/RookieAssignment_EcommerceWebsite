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
    public class CategoriesControllerTests : IClassFixture<SqliteDBService>
    {
        private readonly SqliteDBService _fixture;
        private ApplicationDbContext _dbContext;

        public CategoriesControllerTests(SqliteDBService fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
            _dbContext = _fixture.Context;
        }

        [Fact]
        public async Task GetCategory()
        {
            _dbContext.Categories.Add(new Categories
            {
                CategoryName = "Ghế gaming",
                Description = "Ghế gaming chính hãng, uy tín"
            });
            await _dbContext.SaveChangesAsync();

            var controller = new CategoriesController(_dbContext);
            var result = await controller.GetCategories();

            var actionResult = Assert.IsType<ActionResult<IEnumerable<CategoriesVm>>>(result);
            Assert.NotEmpty(actionResult.Value);
        }     

        [Fact]
        public async Task PostCategory()
        {
            var dbContext = _fixture.Context;
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
        public async Task GetCategoryById()
        {
            _dbContext.Categories.Add(new Categories
            {
                CategoryID = 100,
                CategoryName = "Ghế gaming",
                Description = "Ghế gaming chính hãng, uy tín"
            }); ;

            await _dbContext.SaveChangesAsync();

            var controller = new CategoriesController(_dbContext);
            var result = await controller.GetCategorieById(100);
            var actionResult = Assert.IsType<ActionResult<CategoriesVm>>(result);

            Assert.NotNull(actionResult);
            Assert.NotNull(result);
            Assert.Equal("Ghế gaming", result.Value.CategoryName);
            Assert.Equal("Ghế gaming chính hãng, uy tín", result.Value.Description);
        }

        [Fact]
        public async Task DeleteCategoryById()
        {
            _dbContext.Categories.Add(new Categories
            {
                CategoryID = 100,
                CategoryName = "Ghế gaming",
                Description = "Ghế gaming chính hãng, uy tín"
            }); ;

            await _dbContext.SaveChangesAsync();

            var controller = new CategoriesController(_dbContext);
            var result = await controller.DeleteCategories(100);
            var actionResult = Assert.IsType<OkObjectResult>(result);

            Assert.NotNull(result);
            Assert.NotNull(actionResult);
        }
    }
}
