using products.Domain.Base.Products.Repository;
using products.Domain.Products;

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
            var productEntity = await _dbContext.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return productEntity.Entity;

        }

        public async Task DeleteAsync(Product product)
        {
            _dbContext.Products.Remove(product);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            var productEntry = _dbContext.Update(product);


            await _dbContext.SaveChangesAsync();
            return product;
        }
    }
}
