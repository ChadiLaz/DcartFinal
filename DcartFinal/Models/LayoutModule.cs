using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class LayoutModule
    {
        [Key]
        public int LayoutModuleId { get; set; }
        public int LayoutId { get; set; }
        public string Code { get; set; }
        public string Position { get; set; }
        public int SortOrder { get; set; }
    }
}
