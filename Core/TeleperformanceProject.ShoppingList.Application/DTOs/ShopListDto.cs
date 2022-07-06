using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleperformanceProject.ShoppingList.Application.DTOs
{
    public class ShopListDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime CompletedDate { get; set; } = DateTime.Now;
    }
}
