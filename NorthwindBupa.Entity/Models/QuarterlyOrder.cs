using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class QuarterlyOrder : EntityBase
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
