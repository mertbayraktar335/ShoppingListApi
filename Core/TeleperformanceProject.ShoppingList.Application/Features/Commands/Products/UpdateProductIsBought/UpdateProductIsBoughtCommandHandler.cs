using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Application.Repositories.Products;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.UpdateProductIsBought
{
    public class UpdateProductIsBoughtCommandHandler : IRequestHandler<UpdateProductIsBoughtCommandRequest, UpdateProductIsBoughtCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProductReadRepository _readrepo;

        public UpdateProductIsBoughtCommandHandler(IMapper mapper, IProductReadRepository readrepo)
        {
            _mapper = mapper;
            _readrepo = readrepo;
        }

        public async Task<UpdateProductIsBoughtCommandResponse> Handle(UpdateProductIsBoughtCommandRequest request, CancellationToken cancellationToken)
        {
            
            Product product = await _readrepo.GetByIdAsync(request.Id);

            if (product.IsBought == request.IsBought)
            {
                throw new Exception("değişmedi");
            }
            product.IsBought = request.IsBought;
            await _readrepo.SaveAsync();
            var products = _mapper.Map<ProductDto>(product);
            return new()
            {
                Products = products,
            };
        }
    }
}
