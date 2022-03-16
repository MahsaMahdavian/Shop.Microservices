using products.Domain.Categories;
using products.Domain.Categories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Infrustructure.Categories
{
    public class CategoryWriteRepository : ICategoryWriteRepository
    {
        private readonly ProductDBContext _dbContext;
        public CategoryWriteRepository(ProductDBContext dbContext)
        {
            _dbContext=dbContext;   
        }
        public async Task<Category> AddAsync(Category category)
        {
            var categoryEntity = await _dbContext.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return categoryEntity.Entity;
        }

        public async Task DeleteAsync(Category category)
        {
            _dbContext.Categories.Remove(category);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            var productEntry = _dbContext.Update(category);

            await _dbContext.SaveChangesAsync();
            return category;
        }
    }
}
