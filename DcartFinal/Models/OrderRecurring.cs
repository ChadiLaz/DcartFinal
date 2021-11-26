using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DcartFinal.Models
{
    public class OrderRecurring
    {
        [Key]
        public int OrderRecurringId { get; set; }
        public int OrderId { get; set; }
        public string Reference { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int RecurringId { get; set; }
        public string RecurringName { get; set; }
        public string RecurringDescription { get; set; }
        public string RecurringFrequency { get; set; }
        public short RecurringCycle { get; set; }
        public short RecurringDuration { get; set; }
        public decimal RecurringPrice { get; set; }
        public short Trial { get; set; }
        public string TrialFrequency { get; set; }
        public short TrialCycle { get; set; }
        public short TrialDuration { get; set; }
        public decimal TrialPrice { get; set; }
        public short Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
