using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class SalesTotalsByAmount : EntityBase
    {
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
