using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using products.Application.Exception;
using products.Domain;
using products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Application.Products.Command.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IWriteUnitOfWork _writeUnitOfWork;
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateProductCommandHandler> _logger;

        public UpdateProductCommandHandler(IWriteUnitOfWork writeUnitOfWork, IReadUnitOfWork readUnitOfWork, IMapper mapper, ILogger<UpdateProductCommandHandler> logger)
        {
            _writeUnitOfWork = writeUnitOfWork;
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _readUnitOfWork.ProductReadRepository.GetAsyncNoTracking(request.id);
            if (product == null)
            {
                throw new NotFoundException(nameof(Product), request.id);
            }
            var updatedProduct = _mapper.Map<Domain.Products.Product>(request);
            await _writeUnitOfWork.ProductWriteRepository.UpdateAsync(updatedProduct);
            _logger.LogInformation($"Product {product.id} is successfully updated.");
            return true;
        }
    }
}

