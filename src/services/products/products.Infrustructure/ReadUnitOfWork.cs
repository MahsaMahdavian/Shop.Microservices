using products.Domain;
using products.Domain.Base.Products.Repository;
using products.Infrustructure.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Infrustructure
{
    public class ReadUnitOfWork : IReadUnitOfWork
    {
        private readonly ProductDBContext _dbContext;
        public ReadUnitOfWork(ProductDBContext dBContext)
        {
            _dbContext= dBContext;  
        }
        private ProductReadRepository _productReadRepository;
        public IProductReadRepository ProductReadRepository
        {
                get { return _productReadRepository ??=new ProductReadRepository ( _dbContext ); }   
        }
       
    }
}
