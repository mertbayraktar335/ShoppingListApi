using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Domain.Entities;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;

namespace TeleperformanceProject.ShoppingList.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        IQueryable<T> GetAll();
        T GetWhereIs(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(int id);
        Task<int> SaveAsync();
        
    }
}
