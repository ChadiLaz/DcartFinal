using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CategoryToStore
    {
        [Key]
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
    }
}
