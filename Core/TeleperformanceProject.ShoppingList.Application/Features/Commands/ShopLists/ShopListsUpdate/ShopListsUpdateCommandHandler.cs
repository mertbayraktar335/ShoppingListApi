using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsUpdate
{
    public class ShopListsUpdateCommandHandler : IRequestHandler<ShopListsUpdateCommandRequest, ShopListsupdateCommandResponse>
    {
        private readonly IListsReadRepository _read;
        private readonly IListsWriteRepository _repo;
        public ShopListsUpdateCommandHandler(IListsReadRepository read, IListsWriteRepository repo)
        {
            _read = read;
            _repo = repo;
        }



        public async Task<ShopListsupdateCommandResponse> Handle(ShopListsUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            ShoppList list = await _read.GetByIdAsync(request.Id);
            list.Name = request.Name;
            list.Description = request.Description;
            list.CategoryId = request.CategoryId;
            await _repo.SaveAsync();
            return new() 
            {
            };

        }
    }
}
