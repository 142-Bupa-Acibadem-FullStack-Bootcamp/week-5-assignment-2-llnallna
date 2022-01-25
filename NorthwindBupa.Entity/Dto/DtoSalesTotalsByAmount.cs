using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoSalesTotalsByAmount : DtoBase
    {
        public DtoSalesTotalsByAmount()
        {

        }
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
