using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class CustomerDemographic : EntityBase
    {
        public CustomerDemographic()
        {
            CustomerCustomerDemos = new HashSet<CustomerCustomerDemo>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
