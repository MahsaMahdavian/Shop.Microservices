using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Domain.Base.Products.Repository
{
    public  interface IProductWriteRepository
    {
        Task<Product> AddAsync(Product product);    
        Task<Product> UpdateAsync(Product product); 
        Task DeleteAsync(Product product);
    }
}
