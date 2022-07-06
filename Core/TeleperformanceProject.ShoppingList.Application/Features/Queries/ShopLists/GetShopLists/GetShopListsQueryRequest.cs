using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

#nullable enable
namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetByCategoryId
{
    public class GetShopListsQueryRequest : IRequest<GetShopListsQueryResponse>
    {
        public  Nullable<int> CategoryId { get; set; }

        public Nullable< DateTime> CreatedDate { get; set; }
        public string ?Name  { get; set; }
        public Nullable<DateTime> CompleteDate { get; set; }
    }
}
