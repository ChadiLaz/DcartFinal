using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OrderStatus
    {
        [Key]
        public int OrderStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
