using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoProductsAboveAveragePrice : DtoBase
    {
        public DtoProductsAboveAveragePrice()
        {

        }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
