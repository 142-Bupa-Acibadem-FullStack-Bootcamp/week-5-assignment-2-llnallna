using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoTerritory : DtoBase
    {
        public DtoTerritory()
        {
           
        }

        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        
        
    }
}
