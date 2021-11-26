using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ReturnHistory
    {
        [Key]
        public int ReturnHistoryId { get; set; }
        public int ReturnId { get; set; }
        public int ReturnStatusId { get; set; }
        public short Notify { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
