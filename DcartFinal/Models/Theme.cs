using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Theme
    {
        [Key]
        public int ThemeId { get; set; }
        public int StoreId { get; set; }
        public string ThemeName { get; set; }
        public string Route { get; set; }
        public string Code { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
