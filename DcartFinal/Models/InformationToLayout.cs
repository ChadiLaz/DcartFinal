using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class InformationToLayout
    {
        [Key]
        public int InformationId { get; set; }
        public int StoreId { get; set; }
        public int LayoutId { get; set; }
    }
}
