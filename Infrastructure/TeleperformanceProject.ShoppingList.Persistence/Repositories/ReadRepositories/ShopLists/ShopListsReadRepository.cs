using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Persistence.Contexts;

namespace TeleperformanceProject.ShoppingList.Persistence.Repositories.ReadRepositories.ShopLists
{
    public class ShopListsReadRepository : ReadRepository<ShoppList>, IListsReadRepository
    {
        public ShopListsReadRepository(ShoppingListDbContext context) : base(context)
        {
        }
    }
}
