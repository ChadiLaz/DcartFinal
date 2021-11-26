using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductReward
    {
        [Key]
        public int ProductRewardId { get; set; }
        public int ProductId { get; set; }
        public int CustomerGroupId { get; set; }
        public int Points { get; set; }
    }
}
