using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public int ParentId { get; set; }
        public short Top { get; set; }
        public int Column { get; set; }
        public int SortOrder { get; set; }
        public short Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
