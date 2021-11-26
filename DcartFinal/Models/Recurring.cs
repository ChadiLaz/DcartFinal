using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Recurring
    {
        [Key]
        public int RecurringId { get; set; }
        public decimal Price { get; set; }
        public string Frequency { get; set; }
        public long Duration { get; set; }
        public long Cycle { get; set; }
        public short TrialStatus { get; set; }
        public decimal TrialPrice { get; set; }
        public string TrialFrequency { get; set; }
        public long TrialDuration { get; set; }
        public long TrialCycle { get; set; }
        public short Status { get; set; }
        public int SortOrder { get; set; }
    }
}
