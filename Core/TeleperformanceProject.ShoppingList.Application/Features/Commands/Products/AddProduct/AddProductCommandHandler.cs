using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.Repositories.Products;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Products.AddProduct
{
    
    public class AddProductCommandHandler : IRequestHandler<AddProductCommandRequest, AddProductCommandResponse>
    {
        
        private readonly IProductWriteRepository _repo;

        public AddProductCommandHandler(IProductWriteRepository repo)
        {
            
            _repo = repo;
        }

        public async Task<AddProductCommandResponse> Handle(AddProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product= new Product
            {
                Name=request.Name,
                ListId=request.ListId,
                QuantityId=request.QuantityId,
                QuantityName=request.QuantityName,
                IsBought=request.IsBought

            };
            await _repo.AddAsync(product);
            await _repo.SaveAsync();
            return new()
            {

            };
        }
    }
}
