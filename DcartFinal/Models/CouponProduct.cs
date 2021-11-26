using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CouponProduct
    {
        [Key]
        public int CouponProductId { get; set; }
        public int CouponId { get; set; }
        public int ProductId { get; set; }
    }
}
