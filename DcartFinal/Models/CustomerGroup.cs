using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerGroup
    {
        [Key]
        public int CustomerGroupId { get; set; }
        public int Approval { get; set; }
        public int SortOrder { get; set; }
    }
}
