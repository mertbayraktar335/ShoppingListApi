using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsIsComplete
{
    public class ShopListsIsCompleteCommandRequest : IRequest<ShopListsIsCompleteCommandResponse>
    {
        public int Id { get; set; }
        public bool IsComplete { get; set; }
    }
}
