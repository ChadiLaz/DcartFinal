using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomerHistory
    {
        [Key]
        public int CustomerHistoryId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
