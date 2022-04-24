using MediatR;
using products.Domain.Base;
using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Products.Queries
{
    public class GetProductsListQuery:ProductFilterPageReqDto,IRequest<PaginitionResDto<List<ProductResDto>>>
    {
    }
}
