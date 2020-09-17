using System.Linq;
using Mtt.Api.Services;
using Mtt.Api.Test.Data;
using Xunit;

namespace Mtt.Api.Test.Services
{
    public class CategoryServiceTest
    {
        [Fact]
        public void GetAll_WhenCalled_ReturnsFiveCategories()
        {
            //Arrange
            var fixture = new MttSeedDataFixture("CategoryService");
            var sut = new CategoryService(fixture.MttContext);

            //Act
            var categories = sut.GetAll();

            //Assert
            Assert.NotNull(categories);
            Assert.Equal(5, categories.Result.Count());
        }
    }
}
