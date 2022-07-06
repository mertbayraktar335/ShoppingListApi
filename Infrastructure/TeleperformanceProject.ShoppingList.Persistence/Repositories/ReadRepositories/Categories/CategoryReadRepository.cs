using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Application.Repositories.Categories;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Persistence.Contexts;

namespace TeleperformanceProject.ShoppingList.Persistence.Repositories.ReadRepositories.Categories
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(ShoppingListDbContext context) : base(context)
        {
        }
    }
}
