using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductOptionValue
    {
        [Key]
        public int ProductOptionValueId { get; set; }
        public int ProductOptionId { get; set; }
        public int ProductId { get; set; }
        public int OptionId { get; set; }
        public int OptionValueId { get; set; }
        public int Quantity { get; set; }
        public short Subtract { get; set; }
        public decimal Price { get; set; }
        public string PricePrefix { get; set; }
        public int Points { get; set; }
        public string PointsPrefix { get; set; }
        public decimal Weight { get; set; }
        public string WeightPrefix { get; set; }
    }
}
