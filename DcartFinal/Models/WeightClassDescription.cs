using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class WeightClassDescription
    {
        [Key]
        public int WeightClassId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
    }
}
