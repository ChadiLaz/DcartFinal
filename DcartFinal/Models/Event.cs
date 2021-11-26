using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Code { get; set; }
        public string Trigger { get; set; }
        public string Action { get; set; }
        public short Status { get; set; }
        public int SortOrder { get; set; }
    }
}
