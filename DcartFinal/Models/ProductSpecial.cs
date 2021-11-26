using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductSpecial
    {
        [Key]
        public int ProductSpecialId { get; set; }
        public int ProductId { get; set; }
        public int CustomerGroupId { get; set; }
        public int Priority { get; set; }
        public decimal Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
