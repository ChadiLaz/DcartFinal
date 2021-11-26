using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomFieldValue
    {
        [Key]
        public int CustomFieldValueId { get; set; }
        public int CustomFieldId { get; set; }
        public int SortOrder { get; set; }
    }
}
