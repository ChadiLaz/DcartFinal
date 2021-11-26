using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class ExtensionInstall
    {
        [Key]
        public int ExtensionInstallId { get; set; }
        public int ExtensionDownloadId { get; set; }
        public string Filename { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
