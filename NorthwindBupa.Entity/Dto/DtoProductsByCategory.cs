using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoProductsByCategory : DtoBase
    {
        public DtoProductsByCategory()
        {


        }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
