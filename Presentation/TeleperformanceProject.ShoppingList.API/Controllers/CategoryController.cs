using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.Categories.CategoryAdd;
using TeleperformanceProject.ShoppingList.Application.Features.Commands.Categories.RemoveCategory;
using TeleperformanceProject.ShoppingList.Persistence.Contexts;

namespace TeleperformanceProject.ShoppingList.API.Controllers
{
    [Authorize(AuthenticationSchemes = "Admin")]
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddCategory([FromQuery] CategoryAddCommandRequest categoryAddCommandRequest)
        {
            CategoryAddCommandResponse response = await _mediator.Send(categoryAddCommandRequest);
            return Ok("Eklendi");
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteCategory([FromQuery] CategoryRemoveCommandRequest categoryRemoveCommandRequest)
        {
            CategoryRemoveCommandResponse response = await _mediator.Send(categoryRemoveCommandRequest);
            return Ok("Silindi");
        }

    }
}
