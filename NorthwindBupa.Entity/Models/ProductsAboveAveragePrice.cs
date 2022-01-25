using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class ProductsAboveAveragePrice : EntityBase
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
