using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CategoryPath
    {
        [Key]
        public int CategoryId { get; set; }
        public int PathId { get; set; }
        public int Level { get; set; }
    }
}
