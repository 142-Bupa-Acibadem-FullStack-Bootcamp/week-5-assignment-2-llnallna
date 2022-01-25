using Microsoft.EntityFrameworkCore;
using NorthwindBupa.Dal.Concrete.EntityFramework.Repository;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Concrete.EntityFramework.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public IQueryable CategoryReport(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
