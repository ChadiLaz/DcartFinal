using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class VoucherHistory
    {
        [Key]
        public int VoucherHistoryId { get; set; }
        public int VoucherId { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
