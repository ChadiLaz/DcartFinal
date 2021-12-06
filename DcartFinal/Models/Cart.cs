using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DisplayName("Upload Image Name")]
        public string MainImageURL { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        public DateTime DateAdded { get; set; }
        public decimal Total { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
