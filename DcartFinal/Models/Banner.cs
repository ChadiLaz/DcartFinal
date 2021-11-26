using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Banner
    {
        [Key]
        public int BannerId { get; set; }
        public string Name { get; set; }
        public short Status { get; set; }
    }
}
