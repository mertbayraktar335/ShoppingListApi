using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleperformanceProject.ShoppingList.Domain.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
