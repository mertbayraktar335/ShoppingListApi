using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsAdd
{
    public class ShopListsAddCommandRequest : IRequest<ShopListsAddCommandResponse>
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        
    }
}
