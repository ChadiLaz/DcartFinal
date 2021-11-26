using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class ExtensionPath
    {
        [Key]
        public int ExtensionPathId { get; set; }
        public int ExtensionInstallId { get; set; }
        public string Path { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
