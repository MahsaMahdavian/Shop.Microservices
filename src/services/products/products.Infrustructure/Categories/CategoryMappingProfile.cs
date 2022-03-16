using AutoMapper;
using products.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Infrustructure.Categories
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category, CategoryReqDto>().ReverseMap();
            CreateMap<Category, CategoryResDto>().ReverseMap();

        }
    }
}
