using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OrderTotal
    {
        [Key]
        public int OrderTotalId { get; set; }
        public int OrderId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public decimal Value { get; set; }
        public int SortOrder { get; set; }
    }
}
