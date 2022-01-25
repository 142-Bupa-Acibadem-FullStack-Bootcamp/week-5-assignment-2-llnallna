using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public  class DtoCurrentProductList : DtoBase
    {
        public DtoCurrentProductList()
        {

        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
