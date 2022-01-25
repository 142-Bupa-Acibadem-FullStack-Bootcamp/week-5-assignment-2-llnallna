using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class SummaryOfSalesByYear : EntityBase
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
