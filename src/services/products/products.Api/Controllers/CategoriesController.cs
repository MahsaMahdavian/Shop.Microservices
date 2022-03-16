using MediatR;
using Microsoft.AspNetCore.Mvc;
using products.Application.Categories.Command.Create;
using products.Application.Categories.Command.Delete;
using products.Application.Categories.Command.Update;
using products.Application.Categories.Queries;
using products.Domain.Categories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {


        private readonly IMediator _mediator;
        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<List<CategoryResDto>> GetCategory()
        {
            return await _mediator.Send(new GetCategoriesListQuery());
        }


        [HttpPost]
        public async Task<CategoryResDto> PostCategory(AddCategoryCommand request)
        {
            return await _mediator.Send(request);
        }



        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> PutCategory(int id, UpdateCategoryCommand request)
        {
            if (id != request.id)
            {
                return BadRequest("Id in body and query most be equal");

            }

            var res = await _mediator.Send(request);
            return res;
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteCategory(DeleteCategoryCommand request)
        {
            var res = await _mediator.Send(request);
            return res;
        }
    }
}
