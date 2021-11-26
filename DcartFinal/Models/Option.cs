using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }
        public string Type { get; set; }
        public int SortOrder { get; set; }
    }
}
