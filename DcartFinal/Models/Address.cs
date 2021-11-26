using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int ZoneId { get; set; }
        public Zone Zone { get; set; }
        public string CustomField { get; set; }
    }
}
