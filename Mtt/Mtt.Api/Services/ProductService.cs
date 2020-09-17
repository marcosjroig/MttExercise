using System;
using Mtt.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mtt.Api.Data;

namespace Mtt.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly MttDbContext _mttDbContext;
        public ProductService(MttDbContext mttDbContext)
        {
            _mttDbContext = mttDbContext;
        }

        public async Task<IEnumerable<Product>> GetByCategory(int categoryId)
        {
            try
            {
                return await _mttDbContext.Product.Where(x => x.CategoryId == categoryId).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database exception: " + ex.Message);
            }

            //If there are no products
            return new List<Product>();
        }
    }
}
