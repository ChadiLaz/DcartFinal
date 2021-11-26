using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Zone
    {
        [Key]
        public int ZoneId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public short Status { get; set; }
    }
}
