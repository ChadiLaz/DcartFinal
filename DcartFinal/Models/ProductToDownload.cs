using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductToDownload
    {
        [Key]
        public int ProductId { get; set; }
        public int DownloadId { get; set; }
    }
}
