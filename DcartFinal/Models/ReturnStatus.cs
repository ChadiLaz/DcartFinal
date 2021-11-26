using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ReturnStatus
    {
        [Key]
        public int ReturnStatusId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
