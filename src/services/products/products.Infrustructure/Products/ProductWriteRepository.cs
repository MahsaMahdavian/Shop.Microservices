using products.Domain.Base.Products.Repository;
using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Infrustructure.Products
{
    public class ProductWriteRepository : IProductWriteRepository
    {

        private readonly ProductDBContext _dbContext;
        public ProductWriteRepository(ProductDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<Product> AddAsync(Product product)
        {
            //var ProductEntity=await _dbContext.AddAsync(product);
            throw new NotImplementedException();

        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
