using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class CategorySalesFor1997 : EntityBase
    {
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
