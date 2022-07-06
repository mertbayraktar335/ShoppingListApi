using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TeleperformanceProject.ShoppingList.Application.Repositories;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;
using TeleperformanceProject.ShoppingList.Persistence.Contexts;

namespace TeleperformanceProject.ShoppingList.Persistence.Repositories.ReadRepositories.WriteRepositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ShoppingListDbContext _context;

        public WriteRepository(ShoppingListDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }
        public bool Removee(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }
        public async Task<bool> Remove(int id)
        {
            var model = await Table.FirstOrDefaultAsync(x => x.Id == id);
            return Removee(model);
        }


        public async Task<int> SaveAsync()
        
         =>   await _context.SaveChangesAsync();
        
    }
}
