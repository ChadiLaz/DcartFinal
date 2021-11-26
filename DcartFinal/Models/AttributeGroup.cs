using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class AttributeGroup
    {
        [Key]
        public int AttributeGroupId { get; set; }
        public int SortOrder { get; set; }
    }
}
