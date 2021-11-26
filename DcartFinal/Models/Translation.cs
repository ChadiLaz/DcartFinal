using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Translation
    {
        [Key]
        public int TranslationId { get; set; }
        public int StoreId { get; set; }
        public int LanguageId { get; set; }
        public string Route { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
