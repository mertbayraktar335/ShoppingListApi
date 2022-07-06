using System.Net;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetLists;

namespace TeleperformanceProject.ShoppingList.API.Controllers
{
    [Authorize(AuthenticationSchemes = "Admin")]
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCompletedLists([FromQuery] GetAllCompletedListsQueryRequest shopListsGetAllQueryRequest)
        {
            GetAllCompletedListsQueryResponse response = await _mediator.Send(shopListsGetAllQueryRequest);
            return Ok(response);
        }


    }
}
