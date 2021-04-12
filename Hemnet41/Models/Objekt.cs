using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Hemnet41.Models
{
    public partial class Objekt
    {
        public int HouseId { get; set; }
        public string Images { get; set; }
        public string Adress { get; set; }
        public string HousingType { get; set; }
        public string FormOfLease { get; set; }
        public int Price { get; set; }
        public int Rooms { get; set; }
        public int LivingArea { get; set; }
        public int? BiArea { get; set; }
        public int? PlotArea { get; set; }
        public string Descriptions { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime ShowingDate { get; set; }
        public int BuildYear { get; set; }
        public int? BrookerId { get; set; }

        public virtual Brooker Brooker { get; set; }
    }
}
