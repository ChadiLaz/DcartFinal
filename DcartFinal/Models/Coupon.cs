using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public decimal Discount { get; set; }
        public short Logged { get; set; }
        public short Shipping { get; set; }
        public decimal Total { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int UsesTotal { get; set; }
        public string UsesCustomer { get; set; }
        public short Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
