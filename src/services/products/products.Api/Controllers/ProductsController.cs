using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using products.Application.Products.Command.Create;
using products.Application.Products.Command.Delete;
using products.Application.Products.Command.Update;
using products.Application.Products.Queries;
using products.Domain;
using products.Domain.Products;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

    
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<ProductResDto>> Get()
        {
            return await _mediator.Send(new GetProductsListQuery());
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ProductResDto> Post(AddProductCommand request)
        {
            return await _mediator.Send(request);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, UpdateProductCommand request)
        {
            if (id!= request.id)
            {
                return BadRequest("Id in body and query most be equal");

            }

            var res = await _mediator.Send(request);
            return res;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(DeleteProductCommand request)
        {
            var res = await _mediator.Send(request);
            return res;
        }
    }
}
