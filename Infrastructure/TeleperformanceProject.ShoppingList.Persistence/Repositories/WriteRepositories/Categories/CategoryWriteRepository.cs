using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Application.Repositories.Categories;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Persistence.Contexts;
using TeleperformanceProject.ShoppingList.Persistence.Repositories.ReadRepositories.WriteRepositories;

namespace TeleperformanceProject.ShoppingList.Persistence.Repositories.WriteRepositories.Categories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(ShoppingListDbContext context) : base(context)
        {
        }
    }
}
