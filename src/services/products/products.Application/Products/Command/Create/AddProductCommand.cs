using MediatR;
using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Products.Command.Create
{
    public class AddProductCommand:ProductReqDto,IRequest<ProductResDto>
    {


    }
}
