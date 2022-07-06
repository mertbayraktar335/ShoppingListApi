using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands.Users.UserRegister
{
    public class UserRegisterCommandResponse
    {
       
        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
