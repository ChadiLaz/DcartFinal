using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductFilter
    {
        [Key]
        public int ProductId { get; set; }
        public int FilterId { get; set; }
    }
}
