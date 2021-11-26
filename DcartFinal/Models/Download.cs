using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Download
    {
        [Key]
        public int DownloadId { get; set; }
        public string Filename { get; set; }
        public string Mask { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
