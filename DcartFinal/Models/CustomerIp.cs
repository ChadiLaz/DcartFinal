using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerIp
    {
        [Key]
        public int customer_ip_id { get; set; }
      public int customerid { get; set; }
        public string ip { get; set; }
        //public datetime dateadded { get; set; }
    }
}
