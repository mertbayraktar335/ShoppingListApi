using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;
using TeleperformanceProject.ShoppingList.Domain.Entities.Identity;

namespace TeleperformanceProject.ShoppingList.Domain.Entities
{
    public class ShoppList : BaseEntity
    {

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime CompletedDate { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}


