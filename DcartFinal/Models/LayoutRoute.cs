using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class LayoutRoute
    {
        [Key]
        public int LayoutRouteId { get; set; }
        public int LayoutId { get; set; }
        public int StoreId { get; set; }
        public string Route { get; set; }
    }
}
