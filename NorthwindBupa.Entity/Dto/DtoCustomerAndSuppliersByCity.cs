using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoCustomerAndSuppliersByCity : DtoBase

    {
        public DtoCustomerAndSuppliersByCity()
        {

        }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Relationship { get; set; }
    }
}
