using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Session
    {
        [Key]
        public string SessionId { get; set; }
        public string Data { get; set; }
        public DateTime Expire { get; set; }
    }
}
