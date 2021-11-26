using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerActivity
    {
        [Key]
        public int CustomerActivityId { get; set; }
        public int CustomerId { get; set; }
        public string Key { get; set; }
        public string Data { get; set; }
        //public string ip { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
