using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoSummaryOfSalesByYear : DtoBase
    {
        public DtoSummaryOfSalesByYear()
        {

        }
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
