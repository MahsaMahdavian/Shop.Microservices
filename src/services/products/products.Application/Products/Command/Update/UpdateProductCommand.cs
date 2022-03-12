using MediatR;
using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Products.Command.Update
{
    public class UpdateProductCommand : ProductReqDto, IRequest<bool>
    {
    }
}
