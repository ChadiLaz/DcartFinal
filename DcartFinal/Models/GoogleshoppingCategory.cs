using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class GoogleshoppingCategory
    {
        [Key]
        public string GoogleProductCategory { get; set; }
        public int StoreId { get; set; }
        public int CategoryId { get; set; }
    }
}
