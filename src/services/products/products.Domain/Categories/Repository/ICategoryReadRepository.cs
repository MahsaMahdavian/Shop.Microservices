using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Domain.Categories.Repository
{
    public interface ICategoryReadRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> GetAsyncNoTracking(int id);
    }
}
