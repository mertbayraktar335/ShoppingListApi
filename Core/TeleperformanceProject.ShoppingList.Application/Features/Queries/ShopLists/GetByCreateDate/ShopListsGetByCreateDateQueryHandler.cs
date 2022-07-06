using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetByCreateDate
{
    public class ShopListsGetByCreateDateQueryHandler : IRequestHandler<ShopListsGetByCreateDateQueryRequest, ShopListsGetByCreateDateQueryResponse>
    {
        private readonly IListsReadRepository _read;
        private readonly IMapper _mapper;
        public ShopListsGetByCreateDateQueryHandler(IListsReadRepository read, IMapper mapper)
        {
            _read = read;
            _mapper = mapper;
        }


        public async Task<ShopListsGetByCreateDateQueryResponse> Handle(ShopListsGetByCreateDateQueryRequest request, CancellationToken cancellationToken)
        {
            var list = _read.GetWhere(x => x.CreatedDate == request.CreatedDate);
            var lists = _mapper.ProjectTo<ShopListDto>(list);
            return new()
            {
                ShopLists=lists,
            };
        }
    }
}
