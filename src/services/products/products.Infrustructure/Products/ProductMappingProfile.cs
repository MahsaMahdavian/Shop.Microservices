using AutoMapper;
using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Infrustructure.Products
{
    public class ProductMappingProfile:Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductReqDto>().ReverseMap();
            CreateMap<Product, ProductResDto>().ReverseMap();
        }
    }
}
