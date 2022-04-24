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

        public async Task<Tuple<List<Product>, int>> GetByFilterPageAsync(ProductFilterPageReqDto request)
        {
            var filteredProducts = _dbContext.Products.AsQueryable();
            if (request.Id != 0)
            {
                filteredProducts = filteredProducts.Where(p => p.id == request.Id);
            }

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                request.SearchTerm = request.SearchTerm.Trim().ToLower();
                filteredProducts = filteredProducts.Where(p => p.Title.ToLower().Contains(request.SearchTerm)
                                                               || p.Description.ToLower().Contains(request.SearchTerm)
                                                               || p.Code.ToLower().Contains(request.SearchTerm));

            }

            if (request.MinPrice != null)
            {
                filteredProducts = filteredProducts.Where(p => p.Price >= request.MinPrice);
            }

            if (request.MaxPrice != null)
            {
                filteredProducts = filteredProducts.Where(p => p.Price <= request.MaxPrice);
            }


            if (request.CategoryId != 0)
            {
                filteredProducts = filteredProducts.Where(p => p.CategoryId == request.CategoryId);
            }

            int countOfFilteredProducts = filteredProducts.Count();
            filteredProducts = filteredProducts.Skip(request.PageIndex * request.PageSize).Take(request.PageSize);

            return
                Tuple.Create(await filteredProducts.ToListAsync(), countOfFilteredProducts);
        }
    }
}
