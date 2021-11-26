using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Setting { get; set; }
    }
}
