using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.GetProducts
{
    public class GetProductsQueryRequest :IRequest<GetProductsQueryResponse>
    {
        public int Id { get; set; }
    }
}
