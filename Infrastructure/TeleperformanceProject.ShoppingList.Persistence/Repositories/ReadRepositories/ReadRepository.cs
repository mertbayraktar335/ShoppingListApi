using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeleperformanceProject.ShoppingList.Application.Repositories;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;
using TeleperformanceProject.ShoppingList.Persistence.Contexts;

namespace TeleperformanceProject.ShoppingList.Persistence.Repositories.ReadRepositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ShoppingListDbContext _context;

        public ReadRepository(ShoppingListDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
       => Table;

        public async Task<T> GetByIdAsync(int id)
        => await Table.FindAsync(id);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
         => Table.Where(method);

        public T GetWhereIs(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();
    }
}
