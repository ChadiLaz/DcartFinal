using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Currency
    {
        [Key]
        public int CurrencyId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string SymbolLeft { get; set; }
        public string SymbolRight { get; set; }
        public string DecimalPlace { get; set; }
        public decimal Value { get; set; }
        public short Status { get; set; }
        public DateTime DateModified { get; set; }
    }
}
