using System.Linq;
using Mtt.Api.Services;
using Mtt.Api.Test.Data;
using Xunit;

namespace Mtt.Api.Test.Services
{
    public class ProductServiceTest
    {
        private readonly IProductService _sut;
        public ProductServiceTest()
        {
            var fixture = new MttSeedDataFixture("ProductService");
            _sut = new ProductService(fixture.MttContext);
        }

        [Fact]
        public void GetByCategory_WhenCalled_ReturnsTwoProducts()
        {
            //Act
            var products = _sut.GetByCategory(1);

            //Assert
            Assert.NotNull(products);
            Assert.Equal(2, products.Result.Count());
        }

        [Fact]
        public void GetByCategory_WhenCalled_ReturnsZeroItems()
        {
            //Act
            var products = _sut.GetByCategory(50);

            //Assert
            Assert.Empty(products.Result);
        }
    }
}
