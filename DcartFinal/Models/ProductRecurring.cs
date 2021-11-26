using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ProductRecurring
    {
        [Key]
        public int ProductId { get; set; }
        public int RecurringId { get; set; }
        public int CustomerGroupId { get; set; }
    }
}
