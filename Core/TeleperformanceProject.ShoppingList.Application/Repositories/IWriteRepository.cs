using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;

namespace TeleperformanceProject.ShoppingList.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> Remove(int id);
        bool Removee(T model);
        Task<int> SaveAsync();
    }
}
