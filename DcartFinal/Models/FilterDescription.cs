using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class FilterDescription
    {
        [Key]
        public int FilterId { get; set; }
        public int LanguageId { get; set; }
        public int FilterGroupId { get; set; }
        public string Name { get; set; }
    }
}
