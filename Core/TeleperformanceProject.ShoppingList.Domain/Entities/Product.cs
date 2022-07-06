using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeleperformanceProject.ShoppingList.Domain.Entities.Common;
using TeleperformanceProject.ShoppingList.Domain.Entities.Enums;

namespace TeleperformanceProject.ShoppingList.Domain.Entities
{
    public class Product : BaseEntity
    {
        

        public string QuantityName { get; set; }
        public int QuantityId  { get; set; }
        public ShoppList List { get; set; }
        public int ListId { get; set; }

        public bool IsBought { get; set; } = false;





    }



}



