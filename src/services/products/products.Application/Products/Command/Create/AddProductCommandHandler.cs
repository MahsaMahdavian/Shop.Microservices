﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using products.Domain;
using products.Domain.Products;

namespace products.Application.Products.Command.Create
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductResDto>
    {
        private readonly IWriteUnitOfWork _writeUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<AddProductCommandHandler> _logger;

        public AddProductCommandHandler(IWriteUnitOfWork writeUnitOfWork, IMapper mapper, ILogger<AddProductCommandHandler> logger)
        {
            _writeUnitOfWork = writeUnitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<ProductResDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var newProduct = _mapper.Map<Product>(request);
            var addedProduct= await _writeUnitOfWork.ProductWriteRepository.AddAsync(newProduct);
            _logger.LogInformation($"Product {addedProduct.id} is successfully created.");
            return _mapper.Map<ProductResDto>(addedProduct);
        }
    }
}
