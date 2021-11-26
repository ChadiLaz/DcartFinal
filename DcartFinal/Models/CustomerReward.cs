using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerReward
    {
        [Key]
        public int CustomerRewardId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
