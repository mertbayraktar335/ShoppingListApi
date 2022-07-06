using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleperformanceProject.ShoppingList.Application.DTOs
{
    public class ShopListUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsCompleted { get; set; }
    }
}
