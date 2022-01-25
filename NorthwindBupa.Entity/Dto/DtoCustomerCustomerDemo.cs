using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoCustomerCustomerDemo : DtoBase
    {
        public DtoCustomerCustomerDemo()
        {

        }
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        
    }
}
