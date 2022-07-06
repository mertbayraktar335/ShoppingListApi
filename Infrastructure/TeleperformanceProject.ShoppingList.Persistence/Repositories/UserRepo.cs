using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using TeleperformanceProject.ShoppingList.Application.Repositories;

namespace TeleperformanceProject.ShoppingList.Persistence.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly IHttpContextAccessor _httpContext;

        public UserRepo(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public string GetUserId()
        {
            return _httpContext.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
