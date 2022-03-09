using products.Domain.Base.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Domain
{
    public interface IReadUnitOfWork
    {
        IProductReadRepository ProductReadRepository { get; }   
    }
}
