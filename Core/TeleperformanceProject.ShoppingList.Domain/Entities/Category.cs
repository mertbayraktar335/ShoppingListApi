using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;

namespace TeleperformanceProject.ShoppingList.Domain.Entities
{
    public class Category : BaseEntity
    {


        public string Description { get; set; }

        public ICollection<ShoppList> Lists { get; set; }






    }
}
