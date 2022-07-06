using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeleperformanceProject.ShoppingList.Application.Repositories.Products;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Persistence.Contexts;

namespace TeleperformanceProject.ShoppingList.Persistence.Repositories.ReadRepositories.Products
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ShoppingListDbContext context) : base(context)
        {
        }
    }
}
