using MediatR;
using products.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Categories.Command.Create
{
    public class AddCategoryCommand:CategoryReqDto,IRequest<CategoryResDto>
    {
    }
}
