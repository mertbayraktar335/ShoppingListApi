using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsRemove
{
    public class ShopListsRemoveCommandRequest :  IRequest<ShopListsRemoveCommanResponse>
    {
        public int Id { get; set; }
    }
}
