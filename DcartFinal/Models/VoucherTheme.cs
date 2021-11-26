using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class VoucherTheme
    {
        [Key]
        public int VoucherThemeId { get; set; }
        public string Image { get; set; }
    }
}
