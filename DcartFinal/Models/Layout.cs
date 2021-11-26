using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Layout
    {
        [Key]
        public int LayoutId { get; set; }
        public string Name { get; set; }
    }
}
