using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using products.Domain;
using products.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Categories.Command.Create
{
    public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, CategoryResDto>
    {
        private readonly IWriteUnitOfWork _writeUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<AddCategoryCommandHandler> _logger;

        public AddCategoryCommandHandler(IWriteUnitOfWork writeUnitOfWork, IMapper mapper, ILogger<AddCategoryCommandHandler> logger)
        {
            _writeUnitOfWork = writeUnitOfWork;
            _mapper = mapper;
            _logger = logger;

        }
        public async Task<CategoryResDto> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var newCategory = _mapper.Map<Category>(request);
            var addedCategory = await _writeUnitOfWork.CategoryWriteRepository.AddAsync(newCategory);
            _logger.LogInformation($"Category {addedCategory.id} is successfully created.");
            return _mapper.Map<CategoryResDto>(addedCategory);
        }
    }
}
