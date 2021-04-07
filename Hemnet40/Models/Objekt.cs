using System;
using System.Collections.Generic;

namespace Hemnet40.Models
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
        public DateTime ShowingDate { get; set; }
        public int BuildYear { get; set; }
        public int? BrookerId { get; set; }

        public virtual Brooker Brooker { get; set; }
    }
}
