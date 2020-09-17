using System.Collections.Generic;
using System.Threading.Tasks;
using Mtt.Api.Models;

namespace Mtt.Api.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAll();
    }
}
