using MediatR;
using products.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Categories.Command.Update
{
    public class UpdateCategoryCommand:CategoryReqDto,IRequest<bool>
    {
    }
}
