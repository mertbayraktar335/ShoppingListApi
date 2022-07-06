using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetByCategoryId
{
    public class GetShopListsQueryHandler : IRequestHandler<GetShopListsQueryRequest, GetShopListsQueryResponse>
    {
        private readonly IListsReadRepository _read;
       
        private readonly IMapper _mapper;
        public GetShopListsQueryHandler(IListsReadRepository read,  IMapper mapper)
        {
            _read = read;
            _mapper = mapper;
        }


        public async Task<GetShopListsQueryResponse> Handle(GetShopListsQueryRequest request, CancellationToken cancellationToken)
        {
            var list = _read.GetWhere(
            x => x.CategoryId == request.CategoryId || 
            x.CreatedDate == request.CreatedDate || 
            x.Name == request.Name || 
            x.CompletedDate == request.CompleteDate);
            
            var lists = _mapper.ProjectTo<ShopListDto>(list);

            return new()
            {
                ShopLists = lists,
            };


        }
    }
}
