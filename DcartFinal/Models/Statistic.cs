using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Statistic
    {
        [Key]
        public int StatisticsId { get; set; }
        public string Code { get; set; }
        public decimal Value { get; set; }
    }
}
