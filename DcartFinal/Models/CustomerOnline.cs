using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerOnline
    {
        [Key]
        //public string ip { get; set; }
        public int CustomerId { get; set; }
        public string Url { get; set; }
        public string Referer { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
