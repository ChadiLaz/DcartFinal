using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class AttributeItem
    {
        [Key]
        public int AttributeId { get; set; }
        public int AttributeGroupId { get; set; }
        public AttributeGroup AttributeGroup { get; set; }
        public int SortOrder { get; set; }
    }
}
