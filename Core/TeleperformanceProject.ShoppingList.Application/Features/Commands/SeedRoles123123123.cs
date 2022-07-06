using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TeleperformanceProject.ShoppingList.Domain.Entities.Identity;

namespace TeleperformanceProject.ShoppingList.Application.Features.Commands
{
    public class SeedRoles123123123
    {
        
        public static void SeedRolesAdd(RoleManager<Roles> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                Roles role = new Roles();
                role.Name = "User";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                Roles role = new Roles();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }

        }
    }
}
