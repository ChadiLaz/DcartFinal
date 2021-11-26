using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomFieldValueDescription
    {
        [Key]
        public int CustomFieldValueId { get; set; }
        public int LanguageId { get; set; }
        public int CustomFieldId { get; set; }
        public string Name { get; set; }
    }
}
