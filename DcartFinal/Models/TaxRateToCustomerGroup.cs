using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class TaxRateToCustomerGroup
    {
        [Key]
        public int TaxRateId { get; set; }
        public int CustomerGroupId { get; set; }
    }
}
