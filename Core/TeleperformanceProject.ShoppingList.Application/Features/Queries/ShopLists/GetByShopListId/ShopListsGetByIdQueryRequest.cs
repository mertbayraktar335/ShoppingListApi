using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetById
{
    public class ShopListsGetByIdQueryRequest : IRequest<ShopListsGetByIdQueryResponse>
    {
        public int Id { get; set; }

    }
}
