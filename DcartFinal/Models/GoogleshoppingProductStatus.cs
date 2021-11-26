using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class GoogleshoppingProductStatus
    {
        [Key]
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public string ProductVariationId { get; set; }
        public string DestinationStatuses { get; set; }
        public string DataQualityIssues { get; set; }
        public string ItemLevelIssues { get; set; }
        public int GoogleExpirationDate { get; set; }
    }
}
