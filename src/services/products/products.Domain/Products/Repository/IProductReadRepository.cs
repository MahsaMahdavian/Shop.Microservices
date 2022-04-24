using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Domain.Base.Products.Repository
{
    public  interface IProductReadRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Tuple<List<Product>,int>>GetByFilterPageAsync(ProductFilterPageReqDto productFilterPage);    
        Task<Product> GetByIdAsync(int id);
        Task<Product> GetAsyncNoTracking(int id);
    }
}
