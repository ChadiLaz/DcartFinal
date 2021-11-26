using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class ManufacturerToStore
    {
        [Key]
        public int ManufacturerId { get; set; }
        public int StoreId { get; set; }
    }
}
