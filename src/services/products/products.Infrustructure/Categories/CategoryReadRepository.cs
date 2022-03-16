using Microsoft.EntityFrameworkCore;
using products.Domain.Categories;
using products.Domain.Categories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Infrustructure.Categories
{
    public class CategoryReadRepository : ICategoryReadRepository
    {
        private readonly ProductDBContext _dbContext;

        public CategoryReadRepository(ProductDBContext dbContext)
        {
            _dbContext= dbContext;  
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _dbContext.Categories.Include(C => C.Products).ToListAsync();
        }

        public async Task<Category> GetAsyncNoTracking(int id)
        {
            return await _dbContext.Categories.AsNoTracking().FirstOrDefaultAsync(C =>C.id == id);
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(p => p.id == id);
        }
    }
}
