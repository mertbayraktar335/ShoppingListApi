using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Application.Repositories.Products;
using TeleperformanceProject.ShoppingList.Domain.Entities.Enums;

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQueryRequest, GetProductsQueryResponse>
    {
        private readonly IProductReadRepository _readrepo;
        private readonly IMapper _mapper;
        public GetProductsQueryHandler(IProductReadRepository readrepo, IMapper mapper)
        {
            _readrepo = readrepo;
            _mapper = mapper;
        }

        public async Task<GetProductsQueryResponse> Handle(GetProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var product = _readrepo.GetWhere(x => x.ListId == request.Id);
            var products = _mapper.ProjectTo<ProductDto>(product);
            

            return new()
            {
                Products =products
            };
        }
    }
    }

