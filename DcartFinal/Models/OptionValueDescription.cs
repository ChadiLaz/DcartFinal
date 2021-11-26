using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OptionValueDescription
    {
        [Key]
        public int OptionValueId { get; set; }
        public int LanguageId { get; set; }
        public int OptionId { get; set; }
        public string Name { get; set; }
    }
}
