using System;
using System.Collections.Generic;

#nullable disable

namespace Hemnet41.Models
{
    public partial class RegOfIntrest
    {
        public int HouseId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Objekt House { get; set; }
    }
}
