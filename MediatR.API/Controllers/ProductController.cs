using MediatR.API.Mediatr.Commands;
using MediatR.API.Mediatr.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(Guid Id)
        {
            var query = new GetProductByIdQuery() { Id = Id };
            return Ok(await mediator.Send(query));
        }

        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCommandProduct product)
        {
            return Ok(await mediator.Send(product));
        }
    }
}
