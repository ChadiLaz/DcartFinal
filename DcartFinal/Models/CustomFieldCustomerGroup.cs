using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomFieldCustomerGroup
    {
        [Key]
        public int CustomFieldId { get; set; }
        public int CustomerGroupId { get; set; }
        public short Required { get; set; }
    }
}
