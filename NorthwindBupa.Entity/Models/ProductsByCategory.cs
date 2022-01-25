using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class ProductsByCategory : EntityBase
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
