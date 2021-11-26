using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class VoucherThemeDescription
    {
        [Key]
        public int VoucherThemeId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
