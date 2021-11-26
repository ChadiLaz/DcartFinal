using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CategoryToLayout
    {
        [Key]
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
        public int LayoutId { get; set; }
    }
}
