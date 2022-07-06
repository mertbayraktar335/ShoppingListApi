using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetByShopListsName
{
    public class ShopListsGetByShopListsNameQueryRequest : IRequest<ShopListsGetByShopListsNameQueryResponse>
    {
        public string Name { get; set; }
    }
}
