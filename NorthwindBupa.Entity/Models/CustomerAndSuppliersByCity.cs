using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class CustomerAndSuppliersByCity : EntityBase
    {
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Relationship { get; set; }
    }
}
