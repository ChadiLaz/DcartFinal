using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductDiscount
    {
        [Key]
        public int ProductDiscountId { get; set; }
        public int ProductId { get; set; }
        public int CustomerGroupId { get; set; }
        public int Quantity { get; set; }
        public int Priority { get; set; }
        public decimal Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
