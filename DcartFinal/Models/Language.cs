using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Locale { get; set; }
        public string Image { get; set; }
        public string Directory { get; set; }
        public int SortOrder { get; set; }
        public short Status { get; set; }
    }
}
