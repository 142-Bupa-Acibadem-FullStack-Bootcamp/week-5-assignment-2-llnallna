using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public  class DtoOrderSubtotal : DtoBase
    {
        public DtoOrderSubtotal()
        {

        }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
