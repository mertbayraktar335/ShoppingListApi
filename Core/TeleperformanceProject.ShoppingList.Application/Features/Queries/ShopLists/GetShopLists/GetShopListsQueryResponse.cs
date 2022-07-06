using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetByCategoryId
{
    public class GetShopListsQueryResponse
    {
        public object ShopLists { get; set; }
    }
}
