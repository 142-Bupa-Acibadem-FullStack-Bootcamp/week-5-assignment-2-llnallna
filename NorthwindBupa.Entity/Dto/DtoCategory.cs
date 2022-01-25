using NorthwindBupa.Entity.Base;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Dto
{
    public class DtoCategory : DtoBase

    {
        public DtoCategory()
        {
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        
    }
}
