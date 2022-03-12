using MediatR;
using Microsoft.Extensions.Logging;
using products.Application.Exception;
using products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Products.Command.Delete
{
    public class DeleteProductCommandHandler: IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IWriteUnitOfWork _writeUnitOfWork;
        private readonly IReadUnitOfWork _readUnitOfWork;

        private readonly ILogger<DeleteProductCommandHandler> _logger;

        public DeleteProductCommandHandler(IWriteUnitOfWork writeUnitOfWork, IReadUnitOfWork readUnitOfWork, ILogger<DeleteProductCommandHandler> logger)
        {
            _writeUnitOfWork = writeUnitOfWork;
            _readUnitOfWork = readUnitOfWork;
            _logger = logger;
        }
        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _readUnitOfWork.ProductReadRepository.GetByIdAsync(request.Id);
            if (product == null)
            {
                throw new NotFoundException("Product", request.Id);
            }

            await _writeUnitOfWork.ProductWriteRepository.DeleteAsync(product);

            return true;


        }
    }
}
