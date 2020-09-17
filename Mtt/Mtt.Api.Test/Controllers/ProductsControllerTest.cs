using Microsoft.AspNetCore.Mvc;
using Mtt.Api.Controllers;
using Mtt.Api.Services;
using Mtt.Api.Test.Data;
using Xunit;

namespace Mtt.Api.Test.Controllers
{
    public class ProductsControllerTest
    {
        private readonly MttSeedDataFixture _fixture;
        private readonly ProductsController _sut;
        private int categoryId;
        public ProductsControllerTest()
        {
            _fixture = new MttSeedDataFixture("ProductService");
            IProductService productService = new ProductService(_fixture.MttContext);
            _sut = new ProductsController(productService);
            categoryId = 1;
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //Act
            var okResult = _sut.Get(categoryId).Result;

            //Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        //Simulates an empty table
        [Fact]
        public void Get_WhenCalled_ReturnsNotFound()
        {
            //Arrange
            _fixture.MttContext.Product = null;
            var productService = new ProductService(_fixture.MttContext);
            var sut = new ProductsController(productService);

            //Act
            var notFound = sut.Get(categoryId).Result;

            //Assert
            Assert.IsType<NotFoundObjectResult>(notFound);
        }

        //Filtering by a not existing category
        [Fact]
        public void Get_WhenCalled_with_not_existing_category_ReturnsNotFound()
        {
            //Arrange
            categoryId = 50;

            //Act
            var notFound = _sut.Get(categoryId).Result;

            //Assert
            Assert.IsType<NotFoundObjectResult>(notFound);
        }
    }
}
