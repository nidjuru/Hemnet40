using System;
using System.Collections.Generic;

#nullable disable

namespace Hemnet41.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
