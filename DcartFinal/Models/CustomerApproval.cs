using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerApproval
    {
        [Key]
        public int CustomerApprovalId { get; set; }
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
