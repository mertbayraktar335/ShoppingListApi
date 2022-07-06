using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Categories.CategoryAdd
{
    public class CategoryAddCommandRequest : IRequest<CategoryAddCommandResponse>
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
