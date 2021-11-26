using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OrderRecurringTransaction
    {
        [Key]
        public int OrderRecurringTransactionId { get; set; }
        public int OrderRecurringId { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
