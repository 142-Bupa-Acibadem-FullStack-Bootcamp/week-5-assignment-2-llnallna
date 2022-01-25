using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class CustomerCustomerDemo : EntityBase
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerDemographic CustomerType { get; set; }
    }
}
