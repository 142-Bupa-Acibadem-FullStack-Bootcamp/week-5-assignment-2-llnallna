using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoCategorySalesFor1997 : DtoBase
    {
        public DtoCategorySalesFor1997()
        {

        }
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
