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
    public class WriteUnitOfWork : IWriteUnitOfWork
    {
        private readonly ProductDBContext _dbContext;
        public WriteUnitOfWork(ProductDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        private ProductWriteRepository _productWriteRepository;
        public IProductWriteRepository ProductWriteRepository
        {
            get { return _productWriteRepository ??= new ProductWriteRepository(_dbContext); } 
        }

    }
}
