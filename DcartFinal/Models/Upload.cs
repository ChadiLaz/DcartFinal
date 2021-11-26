using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Upload
    {
        [Key]
        public int UploadId { get; set; }
        public string Name { get; set; }
        public string Filename { get; set; }
        public string Code { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
