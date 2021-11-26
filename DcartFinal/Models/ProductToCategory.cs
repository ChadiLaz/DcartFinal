using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductToCategory
    {
        [Key]
        public int ProductID { get; set; }
        public int CategoryId { get; set; }
    }
}
