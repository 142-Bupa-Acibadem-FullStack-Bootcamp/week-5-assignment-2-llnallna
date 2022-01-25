using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoRegion : DtoBase
    {
        public DtoRegion()
        {

        }
        
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

 
    }
}
