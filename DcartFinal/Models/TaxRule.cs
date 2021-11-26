using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class TaxRule
    {
        [Key]
        public int TaxRuleId { get; set; }
        public int TaxClassId { get; set; }
        public int TaxRateId { get; set; }
        public string Based { get; set; }
        public int Priority { get; set; }
    }
}
