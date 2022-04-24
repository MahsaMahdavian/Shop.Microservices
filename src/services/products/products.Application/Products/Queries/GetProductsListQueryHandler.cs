using AutoMapper;
using MediatR;
using products.Domain;
using products.Domain.Base;
using products.Domain.Products;

namespace products.Application.Products.Queries
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, PaginitionResDto<List<ProductResDto>>>
    {
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IReadUnitOfWork readUnitOfWork, IMapper mapper)
        {
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
        }

        public async Task<PaginitionResDto<List<ProductResDto>>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var productList = await _readUnitOfWork.ProductReadRepository.GetByFilterPageAsync(request);
            PaginitionResDto<List<ProductResDto>> result = new PaginitionResDto<List<ProductResDto>>
            {
                Data = _mapper.Map<List<ProductResDto>>(productList.Item1),
                TotalCount = productList.Item2,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize
            };
            return result;
        }
    }
}
