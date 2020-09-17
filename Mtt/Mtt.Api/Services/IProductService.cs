using System.Collections.Generic;
using System.Threading.Tasks;
using Mtt.Api.Models;

namespace Mtt.Api.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetByCategory(int categoryId);
    }
}
