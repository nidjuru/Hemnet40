using System;
using System.Collections.Generic;

namespace Hemnet40.Models
{
    public partial class RegOfIntrest
    {
        public int HouseId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Objekt House { get; set; }
    }
}
