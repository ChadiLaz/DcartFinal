using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductToStore
    {
        [Key]
        public int ProductId { get; set; }
        public int StoreId { get; set; }
    }
}
