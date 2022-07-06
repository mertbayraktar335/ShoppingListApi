using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleperformanceProject.ShoppingList.Application.DTOs
{
    public class ProductDto
    {
        public string ProductName { get; set; }

        public bool IsBought { get; set; }
        public string ProductQuantity { get; set; }


    }
}
