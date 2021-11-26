using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductAttribute
    {
        [Key]
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public int LanguageId { get; set; }
        public string Text { get; set; }
    }
}
