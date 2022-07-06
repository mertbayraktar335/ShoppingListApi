using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.Products.AddProduct;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.Products.RemoveProduct;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.UpdateProductIsBought;
using TeleperformanceProject.ShoppingList.Application.Features.Queries.GetProducts;


namespace TeleperformanceProject.ShoppingList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {

            _mediator = mediator;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetByListId([FromQuery] GetProductsQueryRequest getProductsQueryRequest)
        {
            GetProductsQueryResponse response = await _mediator.Send(getProductsQueryRequest);
            return Ok(response);

        }

        [HttpPut("[action]")]
        public async Task<IActionResult> ChangeBoughtById([FromQuery] UpdateProductIsBoughtCommandRequest productIsBoughtCommandRequest)
        {

            UpdateProductIsBoughtCommandResponse response = await _mediator.Send(productIsBoughtCommandRequest);
            return Ok(response);

        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveProduct([FromQuery] RemoveProductsCommandRequest removeProductsCommandRequest)
        {
            RemoveProductsCommandResponse response = await _mediator.Send(removeProductsCommandRequest);
            return Ok("Silindi");
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddProduct([FromQuery]AddProductCommandRequest addProductCommandRequest)
        {
            AddProductCommandResponse response = await _mediator.Send(addProductCommandRequest);
            return Ok(response);
        }
            
     }
}
