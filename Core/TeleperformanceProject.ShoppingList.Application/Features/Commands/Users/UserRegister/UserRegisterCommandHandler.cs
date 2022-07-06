using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Domain.Entities.Identity;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Users.UserRegister
{
    public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommandRequest, UserRegisterCommandResponse>
    {
        readonly UserManager<User> _userManager;
        readonly RoleManager<Roles> _roleManager;
        public UserRegisterCommandHandler(UserManager<User> userManager, RoleManager<Roles> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<UserRegisterCommandResponse> Handle(UserRegisterCommandRequest request, CancellationToken cancellationToken)
        {
           IdentityResult result = await _userManager.CreateAsync(new() 
            {
                Id=Guid.NewGuid().ToString(),
                UserName=request.Username,
                Email=request.Email,
                Name=request.Name,
                Surname=request.Surname,


            },request.Password);
            UserRegisterCommandResponse response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
            {
                
                response.Message = "Kullanıcı Oluşturuldu!";
                var user =  await _userManager.FindByEmailAsync(request.Email);
                await _userManager.AddToRoleAsync(user, "User");
                
            }
            
            else
            {
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description}";
                }
               
            }
            return response;
        }
    }
}
