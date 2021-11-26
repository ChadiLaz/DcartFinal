using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public int CustomerGroupId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Cart { get; set; }
        public string Wishlist { get; set; }
        public short Newsletter { get; set; }
        public int AddressId { get; set; }
        public string CustomField { get; set; }
        //public string ip { get; set; }
        public short Status { get; set; }
        public short Safe { get; set; }
        public string Token { get; set; }
        public string Code { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
