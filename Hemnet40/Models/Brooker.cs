using System;
using System.Collections.Generic;

namespace Hemnet40.Models
{
    public partial class Brooker
    {
        public Brooker()
        {
            Objekt = new HashSet<Objekt>();
        }

        public int BrookerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Objekt> Objekt { get; set; }
    }
}
