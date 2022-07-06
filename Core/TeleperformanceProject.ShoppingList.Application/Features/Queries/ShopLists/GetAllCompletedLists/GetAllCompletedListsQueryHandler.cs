using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetLists
{
    public class GetAllCompletedListsQueryHandler : IRequestHandler<GetAllCompletedListsQueryRequest, GetAllCompletedListsQueryResponse>
    {
        private readonly IListsReadRepository _read;
        private readonly IMapper _mapper;

        public GetAllCompletedListsQueryHandler(IListsReadRepository read, IMapper mapper)
        {
            _read = read;
            _mapper = mapper;
        }

        public async Task<GetAllCompletedListsQueryResponse> Handle(GetAllCompletedListsQueryRequest request, CancellationToken cancellationToken)
        {
            var list = _read.GetWhere(x => x.IsCompleted == true);
           
            var lists = _mapper.ProjectTo<ShopListDto>(list);
            return new()
            {
                ShopLists=lists,
            };
        }
    }
}
