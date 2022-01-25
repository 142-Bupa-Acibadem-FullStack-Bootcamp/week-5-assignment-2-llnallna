using Microsoft.EntityFrameworkCore;
using NorthwindBupa.Dal.Concrete.EntityFramework.Repository;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Interface;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

#nullable disable

namespace NorthwindBupa.Concrete.EntityFramework.Repository
{
    public class CategorySalesFor1997Repository : GenericRepository<CategorySalesFor1997>, ICategorySalesFor1997Repository
    {
        public CategorySalesFor1997Repository(DbContext context) : base(context)
        {
        }
    }
}
