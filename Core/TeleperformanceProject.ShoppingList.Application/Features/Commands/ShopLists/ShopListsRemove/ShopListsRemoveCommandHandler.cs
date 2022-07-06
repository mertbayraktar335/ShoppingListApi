using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsRemove
{
    public class ShopListsRemoveCommandHandler : IRequestHandler<ShopListsRemoveCommandRequest, ShopListsRemoveCommanResponse>
    {
        private readonly IListsWriteRepository _repo;
        private readonly IListsReadRepository _read;

        public ShopListsRemoveCommandHandler(IListsWriteRepository repo, IListsReadRepository read)
        {
            _repo = repo;
            _read = read;
        }

        public async Task<ShopListsRemoveCommanResponse> Handle(ShopListsRemoveCommandRequest request, CancellationToken cancellationToken)
        {
            ShoppList list = await _read.GetByIdAsync(request.Id);
             _repo.Removee(list);
            await _repo.SaveAsync();
            return new()
            {
                ShopList = list,
            };
        }
    }
}
