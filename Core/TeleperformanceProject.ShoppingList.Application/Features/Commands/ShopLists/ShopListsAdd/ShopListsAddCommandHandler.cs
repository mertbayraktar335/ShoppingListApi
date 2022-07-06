using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

using TeleperformanceProject.ShoppingList.Application.Repositories;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.ShopLists.ShopListsAdd
{
    public class ShopListsAddCommandHandler : IRequestHandler<ShopListsAddCommandRequest, ShopListsAddCommandResponse>
    {
        private readonly IListsWriteRepository _repo;
      
        private readonly IUserRepo _userRepo;
      
        public ShopListsAddCommandHandler(IListsWriteRepository listRepo, IUserRepo userRepo)
        {
            _repo = listRepo;
           
            _userRepo = userRepo;
            
        }

        public async Task<ShopListsAddCommandResponse> Handle(ShopListsAddCommandRequest request, CancellationToken cancellationToken)
        {

            var userId = _userRepo.GetUserId();




            await _repo.AddAsync(new()
            {
                
                CategoryId = request.CategoryId,
                Name = request.Name,
                Description = request.Description,
                UserId= userId
                
            });

            await _repo.SaveAsync();
            return new()
            {
                
            };
            
        }
    }
}
