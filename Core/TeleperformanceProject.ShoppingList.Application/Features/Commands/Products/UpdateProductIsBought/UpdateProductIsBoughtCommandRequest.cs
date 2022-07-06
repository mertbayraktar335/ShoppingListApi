using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.DTOs;


namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.UpdateProductIsBought
{
    public class UpdateProductIsBoughtCommandRequest : IRequest<UpdateProductIsBoughtCommandResponse>
    {
       //public ProductUpdateDto productUpdateDto { get; set; }
        public int Id { get; set; }
        public bool IsBought { get; set; }
    }
}
