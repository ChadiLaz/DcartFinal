using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
   
    public class AttributeDescription
    {
        [Key]
        public int AttributeId { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}
