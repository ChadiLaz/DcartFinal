using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductRelated
    {
        [Key]
        public int ProductId { get; set; }
        public int RelatedId { get; set; }
    }
}
