using MediatR.Example.Requests.Product.ChangeProductPrice;
using MediatR.Example.Requests.Product.CreateProduct;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("{:id}/price")]
        public async Task<IActionResult> UpdatePrice([FromBody] Decimal price, [FromRoute] int id)
        {
            await _mediator.Send(new ChangeProductPriceRequest(id, price));
            return NoContent();
        }
    }
}
