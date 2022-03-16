using AutoMapper;
using MediatR;
using products.Domain;
using products.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Categories.Queries
{
    public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryResDto>>
    {
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;

        public GetCategoriesListQueryHandler(IReadUnitOfWork readUnitOfWork, IMapper mapper)
        {
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;

        }


        public async Task<List<CategoryResDto>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var categoryList = await _readUnitOfWork.CategoryReadRepository.GetAllAsync();
            return _mapper.Map<List<CategoryResDto>>(categoryList);
        }
    }
}
