using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class WeightClass
    {
        [Key]
        public int WeightClassId { get; set; }
        public decimal Value { get; set; }
    }
}
