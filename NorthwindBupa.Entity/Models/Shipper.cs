using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class Shipper : EntityBase
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
