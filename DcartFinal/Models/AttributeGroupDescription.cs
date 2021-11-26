using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class AttributeGroupDescription
    {
        [Key]
        public int AttributeGroupId { get; set; }
        public AttributeGroup MyProperty { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
