using System;
using Microsoft.EntityFrameworkCore;
using Mtt.Api.Models;

namespace Mtt.Api.Data
{
    public class MttDbContext : DbContext
    {
        public MttDbContext(DbContextOptions<MttDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
