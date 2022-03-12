using Microsoft.EntityFrameworkCore;
using products.Domain.Base.Products.Repository;
using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Infrustructure.Products
{
    public class ProductReadRepository : IProductReadRepository
    {
        private readonly ProductDBContext _dbContext;
        public ProductReadRepository(ProductDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<List<Product>> GetAllAsync()
        {
           return await _dbContext.Products.Include(p=>p.Category).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(p => p.id==id);
        }
        public async Task<Product> GetAsyncNoTracking(int id)
        {
            return await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(p => p.id == id);
        }
    }
}
