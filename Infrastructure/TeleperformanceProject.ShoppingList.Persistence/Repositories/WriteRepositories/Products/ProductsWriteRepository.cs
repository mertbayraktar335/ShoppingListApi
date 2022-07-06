using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Application.Repositories.Products;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Persistence.Contexts;
using TeleperformanceProject.ShoppingList.Persistence.Repositories.ReadRepositories.WriteRepositories;

namespace TeleperformanceProject.ShoppingList.Persistence.Repositories.WriteRepositories.Products
{
    public class ProductsWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductsWriteRepository(ShoppingListDbContext context) : base(context)
        {
        }
    }
}
