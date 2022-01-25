using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class Region : EntityBase
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territory> Territories { get; set; }
    }
}
