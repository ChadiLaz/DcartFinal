using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Modification
    {
        [Key]
        public int ModificationId { get; set; }
        public int ExtensionInstallId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Author { get; set; }
        public string Version { get; set; }
        public string Link { get; set; }
        public string Xml { get; set; }
        public short Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
