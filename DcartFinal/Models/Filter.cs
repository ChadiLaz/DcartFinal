using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Filter
    {
        [Key]
        public int FilterId { get; set; }
        public int FilterGroupId { get; set; }
        public int SortOrder { get; set; }
    }
}
