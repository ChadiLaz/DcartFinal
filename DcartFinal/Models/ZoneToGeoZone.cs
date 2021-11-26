using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DcartFinal.Models
{
    public class ZoneToGeoZone
    {
        [Key]
        public int ZoneToGeoZoneId { get; set; }
        public int CountryId { get; set; }
        public int ZoneId { get; set; }
        public int GeoZoneId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}
