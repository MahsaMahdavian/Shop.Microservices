using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using products.Application.Exception;
using products.Domain;
using products.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Categories.Command.Update
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, bool>
    {
        private readonly IWriteUnitOfWork _writeUnitOfWork;
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateCategoryCommandHandler> _logger;

        public UpdateCategoryCommandHandler(IWriteUnitOfWork writeUnitOfWork, IReadUnitOfWork readUnitOfWork, IMapper mapper, ILogger<UpdateCategoryCommandHandler> logger)
        {
            _writeUnitOfWork = writeUnitOfWork;
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
            _logger = logger;

        }

        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _readUnitOfWork.CategoryReadRepository.GetAsyncNoTracking(request.id);
            if (category == null)
            {
                throw new NotFoundException(nameof(Category), request.id);
            }
            var updatedCategory= _mapper.Map<Category>(request);
            await _writeUnitOfWork.CategoryWriteRepository.UpdateAsync(updatedCategory);
            _logger.LogInformation($"Category {category.id} is successfully updated.");
            return true;
        }
    }
}
