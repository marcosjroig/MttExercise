using System;
using Microsoft.EntityFrameworkCore;
using Mtt.Api.Data;
using Mtt.Api.Models;

namespace Mtt.Api.Test.Data
{
    public class MttSeedDataFixture : IDisposable
    {
        public MttDbContext MttContext { get; }

        public MttSeedDataFixture(string name)
        {
            var databaseName = "MttDatabase_" + name + "_" + DateTime.Now.ToFileTimeUtc();
            var options = new DbContextOptionsBuilder<MttDbContext>()
                .UseInMemoryDatabase(databaseName)
                .Options;

            MttContext = new MttDbContext(options);

            // Load categories
            MttContext.Category.Add(new Category { Id = 1, Name = "Home" });
            MttContext.Category.Add(new Category { Id = 2, Name = "Garden" });
            MttContext.Category.Add(new Category { Id = 3, Name = "Electronics" });
            MttContext.Category.Add(new Category { Id = 4, Name = "Fitness" });
            MttContext.Category.Add(new Category { Id = 5, Name = "Toys" });

            //Load Products
            MttContext.Product.Add(new Product { Sku = 1, Name = "Chair", Description = "Chair description", Price = 25, CategoryId = 1});
            MttContext.Product.Add(new Product { Sku = 2, Name = "Table", Description = "Table description", Price = 30, CategoryId = 1 });

            MttContext.SaveChanges();
        }

        public void Dispose()
        {
            MttContext.Dispose();
        }
    }
}
