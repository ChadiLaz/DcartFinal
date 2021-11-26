using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class GoogleshoppingProductTarget
    {
        [Key]
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public long AdvertiseGoogleTargetId { get; set; }
    }
}
