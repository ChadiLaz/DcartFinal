using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OrderShipment
    {
        [Key]
        public int OrderShipmentId { get; set; }
        public int OrderId { get; set; }
        public DateTime DateAdded { get; set; }
        public string ShippingCourierId { get; set; }
        public string TrackingNumber { get; set; }
    }
}
