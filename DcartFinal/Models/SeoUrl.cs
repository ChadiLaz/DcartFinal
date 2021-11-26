using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class SeoUrl
    {
        [Key]
        public int SeoUrlId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public string Query { get; set; }
        public string Keyword { get; set; }
    }
}
