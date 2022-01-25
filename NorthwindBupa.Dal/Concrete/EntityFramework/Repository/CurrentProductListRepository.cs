using Microsoft.EntityFrameworkCore;
using NorthwindBupa.Dal.Concrete.EntityFramework.Repository;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Interface;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Entity.Concrete.EntityFramework.Repository
{
    public class CurrentProductListRepository : GenericRepository<CurrentProductList>, ICurrentProductListRepository
    {
        public CurrentProductListRepository(DbContext context) : base(context)
        {
        }
    }
}
