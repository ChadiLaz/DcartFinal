using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class GoogleshoppingProduct
    {
        [Key]
        public long ProductAdvertiseGoogleId { get; set; }
        public int? ProductId { get; set; }
        public int StoreId { get; set; }
        public short? HasIssues { get; set; }
        public string DestinationStatus { get; set; }
        public int Impressions { get; set; }
        public int Clicks { get; set; }
        public int Conversions { get; set; }
        public decimal Cost { get; set; }
        public decimal ConversionValue { get; set; }
        public string GoogleProductCategory { get; set; }
        public string Condition { get; set; }
        public short? Adult { get; set; }
        public int? Multipack { get; set; }
        public short? IsBundle { get; set; }
        public string AgeGroup { get; set; }
        public int? Color { get; set; }
        public string Gender { get; set; }
        public string SizeType { get; set; }
        public string SizeSystem { get; set; }
        public int? Size { get; set; }
        public short IsModified { get; set; }
    }
}
