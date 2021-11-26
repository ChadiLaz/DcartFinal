using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OrderOption
    {
        [Key]
        public int OrderOptionId { get; set; }
        public int OrderId { get; set; }
        public int OrderProductId { get; set; }
        public int ProductOptionId { get; set; }
        public int ProductOptionValueId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}
