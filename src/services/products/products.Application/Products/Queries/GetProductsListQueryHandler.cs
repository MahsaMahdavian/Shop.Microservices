using AutoMapper;
using MediatR;
using products.Domain;
using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Products.Queries
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductResDto>>
    {
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IReadUnitOfWork readUnitOfWork, IMapper mapper)
        {
            _readUnitOfWork = readUnitOfWork;   
            _mapper = mapper;   
        }

        public async Task<List<ProductResDto>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var productList =await _readUnitOfWork.ProductReadRepository.GetAllAsync();
            return _mapper.Map<List<ProductResDto>>(productList);
        }
    }
}
