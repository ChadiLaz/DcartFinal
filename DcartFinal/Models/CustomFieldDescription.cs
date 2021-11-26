using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomFieldDescription
    {
        [Key]
        public int CustomFieldId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
