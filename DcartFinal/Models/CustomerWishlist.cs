using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerWishlist
    {
        [Key]
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
