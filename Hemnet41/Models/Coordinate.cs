using System;
using System.Collections.Generic;

#nullable disable

namespace Hemnet41.Models
{
    public partial class Coordinate
    {
        public Coordinate()
        {
            Objekts = new HashSet<Objekt>();
        }

        public int CoordinateId { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }

        public virtual ICollection<Objekt> Objekts { get; set; }
    }
}
