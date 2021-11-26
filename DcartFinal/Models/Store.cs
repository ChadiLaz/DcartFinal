using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Ssl { get; set; }
    }
}
