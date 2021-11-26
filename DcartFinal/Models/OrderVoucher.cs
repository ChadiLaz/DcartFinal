using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OrderVoucher
    {
        [Key]
        public int OrderVoucherId { get; set; }
        public int OrderId { get; set; }
        public int VoucherId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public int VoucherThemeId { get; set; }
        public string Message { get; set; }
        public decimal Amount { get; set; }
    }
}
