using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Information
    {
        [Key]
        public int InformationId { get; set; }
        public int Bottom { get; set; }
        public int SortOrder { get; set; }
        public short Status { get; set; }
    }
}
