using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Application.DTOs;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Users.UserLogin
{
    public class UserLoginCommandResponse
    {
        public Token Token { get; set; }
    }
}
