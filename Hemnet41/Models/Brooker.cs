using System;
using System.Collections.Generic;

#nullable disable

namespace Hemnet41.Models
{
    public partial class Brooker
    {
        public Brooker()
        {
            Objekts = new HashSet<Objekt>();
        }

        public int BrookerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Objekt> Objekts { get; set; }
    }
}
