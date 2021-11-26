using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Voucher
    {
        [Key]
        public int VoucherId { get; set; }
        public int OrderId { get; set; }
        public string Code { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public int VoucherThemeId { get; set; }
        public string Message { get; set; }
        public decimal Amount { get; set; }
        public short Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
