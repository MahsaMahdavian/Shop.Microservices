using products.Domain;
using products.Domain.Base.Products.Repository;
using products.Domain.Categories.Repository;
using products.Infrustructure.Categories;
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
        private CategoryWriteRepository _categoryWriteRepository;
        public IProductWriteRepository ProductWriteRepository
        {
            get { return _productWriteRepository ??= new ProductWriteRepository(_dbContext); } 
        }
        public ICategoryWriteRepository CategoryWriteRepository
        {
            get { return _categoryWriteRepository ??= new CategoryWriteRepository(_dbContext); }
        }

    }
}
