using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TeleperformanceProject.ShoppingList.Application.DTOs;
using TeleperformanceProject.ShoppingList.Application.Exceptions;
using TeleperformanceProject.ShoppingList.Application.Tokens;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Users.UserLogin
{
    public class UserLoginCommandHandler : IRequestHandler<UserLoginCommandRequest, UserLoginCommandResponse>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenHandler _handler;
        public UserLoginCommandHandler(UserManager<User> userManager, SignInManager<User> signInManager, ITokenHandler handler)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _handler = handler;
        }

        public async Task<UserLoginCommandResponse> Handle(UserLoginCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await _userManager.FindByNameAsync(request.UsernameOrEmail);
            if (user == null)
            {
                user = await _userManager.FindByEmailAsync(request.UsernameOrEmail);
            }
            if (user==null)
            {
                throw new UserNotFoundException("Kullanıcı Adı veya Email Hatalı");
            }
            SignInResult result= await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!result.Succeeded)
            {
                throw new UserNotFoundException("Kullanıcı Adı/Email veya Şifre Hatalı");
            }
            else
            {
                Token token = await _handler.CreateToken(5,user);
                return new()
                {
                    Token= token,
                };
            }

            
        }
    }
}
