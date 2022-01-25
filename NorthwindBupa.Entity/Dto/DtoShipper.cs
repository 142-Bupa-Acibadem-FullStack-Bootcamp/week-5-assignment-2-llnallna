using NorthwindBupa.Entity.Base;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoShipper : DtoBase
    {
        public DtoShipper()
        {

        }
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

       
    }
}
