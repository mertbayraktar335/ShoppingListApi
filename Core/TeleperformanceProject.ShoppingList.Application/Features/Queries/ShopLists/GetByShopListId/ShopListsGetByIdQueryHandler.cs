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

namespace TeleperformanceProject.ShoppingList.Application.Features.Queries.ShopLists.GetById
{
    public class ShopListsGetByIdQueryHandler : IRequestHandler<ShopListsGetByIdQueryRequest, ShopListsGetByIdQueryResponse>
    {
        private readonly IListsReadRepository _read;
        private readonly IListsWriteRepository _repo;
        private readonly IMapper _mapper;
        public ShopListsGetByIdQueryHandler(IListsReadRepository read, IListsWriteRepository repo, IMapper mapper)
        {
            _read = read;
            _repo = repo;
            _mapper = mapper;
        }


        public async Task<ShopListsGetByIdQueryResponse> Handle(ShopListsGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            ShoppList list = await _read.GetByIdAsync(request.Id);
            var lists = _mapper.Map<ShopListAddDto>(list);
            await _repo.SaveAsync();
            return new()
            {
                ShopLists = lists,
            };
        }
    }
}
