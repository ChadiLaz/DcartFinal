using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ReturnAction
    {
        [Key]
        public int ReturnActionId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    }
}
