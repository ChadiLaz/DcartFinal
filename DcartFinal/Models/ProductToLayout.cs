using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductToLayout
    {
        [Key]
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int LayoutId { get; set; }
    }
}
