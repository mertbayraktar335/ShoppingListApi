using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.Repositories.Products;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Products.RemoveProduct
{
    public class RemoveProductsCommandHandler : IRequestHandler<RemoveProductsCommandRequest, RemoveProductsCommandResponse>
    {
        private readonly IProductReadRepository _read;
        private readonly IProductWriteRepository _repo;

        public RemoveProductsCommandHandler(IProductWriteRepository repo, IProductReadRepository read)
        {
            _repo = repo;
            _read = read;
        }

        public async Task<RemoveProductsCommandResponse> Handle(RemoveProductsCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = await _read.GetByIdAsync(request.Id);
            _repo.Removee(product);
            await _repo.SaveAsync();
            return new()
            {

            };
        }
    }
}
