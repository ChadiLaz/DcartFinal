using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OptionValue
    {
        [Key]
        public int OptionValueId { get; set; }
        public int OptionId { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
