using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
   
    public class CategoryFilter
    {
        [Key]
        public int CategoryId { get; set; }
        public int FilterId { get; set; }
    }
}
