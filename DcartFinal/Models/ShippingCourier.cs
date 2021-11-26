using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ShippingCourier
    {
        [Key]
        public int ShippingCourierId { get; set; }
        public string ShippingCourierCode { get; set; }
        public string ShippingCourierName { get; set; }
    }
}
