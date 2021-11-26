using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class LengthClass
    {
        [Key]
        public int LengthClassId { get; set; }
        public decimal Value { get; set; }
    }
}
