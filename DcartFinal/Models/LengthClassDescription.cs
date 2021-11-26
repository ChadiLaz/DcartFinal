using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class LengthClassDescription
    {
        [Key]
        public int LengthClassId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
    }
}
