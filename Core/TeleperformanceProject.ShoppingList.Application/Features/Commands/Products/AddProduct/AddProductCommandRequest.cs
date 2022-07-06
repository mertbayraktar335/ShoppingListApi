using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Products.AddProduct
{
    public class AddProductCommandRequest : IRequest<AddProductCommandResponse>
    {
        public string Name { get; set; }
        public int ListId { get; set; }
        public int QuantityId { get; set; }
        public string QuantityName { get; set; }
        public bool IsBought { get; set; }
    }
}
