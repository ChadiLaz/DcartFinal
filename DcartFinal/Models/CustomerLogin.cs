using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerLogin
    {
        [Key]
        public int CustomerLoginId { get; set; }
        public string Email { get; set; }
        //public string ip { get; set; }
        public int Total { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
