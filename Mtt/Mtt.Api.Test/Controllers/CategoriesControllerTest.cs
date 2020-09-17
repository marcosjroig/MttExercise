using Microsoft.AspNetCore.Mvc;
using Mtt.Api.Controllers;
using Mtt.Api.Services;
using Mtt.Api.Test.Data;
using Xunit;

namespace Mtt.Api.Test.Controllers
{
    public class CategoriesControllerTest
    {
        private readonly MttSeedDataFixture _fixture;
        private readonly CategoriesController _sut;
        public CategoriesControllerTest()
        {
            //Arrange
            _fixture = new MttSeedDataFixture("CategoryService");
            ICategoryService categoryService = new CategoryService(_fixture.MttContext);
            _sut = new CategoriesController(categoryService);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = _sut.Get().Result;

            //Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        //Simulates an empty table
        [Fact]
        public void GetAll_WhenCalled_ReturnsNotFound()
        {
            //Arrange
            _fixture.MttContext.Category = null;
            var categoryService = new CategoryService(_fixture.MttContext);
            var sut = new CategoriesController(categoryService);

            //Act
            var notFound = sut.Get().Result;

            //Assert
            Assert.IsType<NotFoundObjectResult>(notFound);
        }
    }
}
