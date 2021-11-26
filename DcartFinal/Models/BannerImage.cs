using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class BannerImage
    {
        [Key]
        public int BannerImageId { get; set; }
        public int BannerId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }
    }
}
