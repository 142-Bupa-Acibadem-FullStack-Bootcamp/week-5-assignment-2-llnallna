using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoCustomerDemographic : DtoBase
    {
        

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        
    }
}
