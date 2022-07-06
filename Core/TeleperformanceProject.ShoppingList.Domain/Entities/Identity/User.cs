using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;

namespace TeleperformanceProject.ShoppingList.Domain.Entities
{
    public class User : IdentityUser<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<ShoppList> Lists { get; set; }

    }
}
