using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;

namespace TeleperformanceProject.ShoppingList.Application.Repositories
{
    public  interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
