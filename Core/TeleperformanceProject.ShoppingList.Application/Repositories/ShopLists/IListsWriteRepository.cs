using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Domain.Entities;

namespace TeleperformanceProject.ShoppingList.Application.Repositories.ShopLists
{
    public interface IListsWriteRepository : IWriteRepository<ShoppList>
    {
    }
}
