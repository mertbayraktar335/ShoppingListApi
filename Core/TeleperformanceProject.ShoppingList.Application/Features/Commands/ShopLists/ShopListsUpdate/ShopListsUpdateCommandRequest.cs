using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsUpdate
{
    public class ShopListsUpdateCommandRequest : IRequest<ShopListsupdateCommandResponse>
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name   { get; set; }
        public string Description { get; set; }
    }
}
