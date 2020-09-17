using System;
using Mtt.Api.Data;
using Mtt.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mtt.Api.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly MttDbContext _mttDbContext;
        public CategoryService(MttDbContext mttDbContext)
        {
            _mttDbContext = mttDbContext;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            try
            {
                return await _mttDbContext.Category.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database exception: " + ex.Message);
            }

            //If there are no categories
            return new List<Category>();
        }
    }
}
