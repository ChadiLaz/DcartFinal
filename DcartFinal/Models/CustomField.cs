using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class CustomField
    {
        [Key]
        public int CustomFieldId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Validation { get; set; }
        public string Location { get; set; }
        public short Status { get; set; }
        public int SortOrder { get; set; }
    }
}
