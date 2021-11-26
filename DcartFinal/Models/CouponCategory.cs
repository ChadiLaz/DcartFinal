using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CouponCategory
    {
        [Key]
        public int CouponId { get; set; }
        public int CategoryId { get; set; }
    }
}
