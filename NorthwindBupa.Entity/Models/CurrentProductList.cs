using NorthwindBupa.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Models
{
    public partial class CurrentProductList : EntityBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
