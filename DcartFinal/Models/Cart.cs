using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Cart
    {
        [Key]
        public long CartId { get; set; }
        //public int api_id { get; set; }
        public int CustomerId { get; set; }
        public string SessionId { get; set; }
        public int ProductId { get; set; }
        public int RecurringId { get; set; }
        public string Option { get; set; }
        public int Quantity { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
