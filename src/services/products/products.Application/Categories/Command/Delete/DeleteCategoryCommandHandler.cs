using MediatR;
using Microsoft.Extensions.Logging;
using products.Application.Exception;
using products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Categories.Command.Delete
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {

        private readonly IWriteUnitOfWork _writeUnitOfWork;
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly ILogger<DeleteCategoryCommandHandler> _logger;

        public DeleteCategoryCommandHandler(IWriteUnitOfWork writeUnitOfWork, IReadUnitOfWork readUnitOfWork, ILogger<DeleteCategoryCommandHandler> logger)
        {
            _writeUnitOfWork = writeUnitOfWork;
            _readUnitOfWork = readUnitOfWork;
            _logger = logger;

        }
        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _readUnitOfWork.CategoryReadRepository.GetByIdAsync(request.Id);
            if (category == null)
            {
                throw new NotFoundException("Category", request.Id);
            }

            await _writeUnitOfWork.CategoryWriteRepository.DeleteAsync(category);

            return true;
        }
    }
}
