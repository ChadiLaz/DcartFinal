using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Extension
    {
        [Key]
        public int ExtensionId { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
    }
}
