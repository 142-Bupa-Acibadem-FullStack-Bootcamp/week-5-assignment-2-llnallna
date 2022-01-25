using Microsoft.EntityFrameworkCore;
using NorthwindBupa.Dal.Abstract;
using NorthwindBupa.Dal.Concrete.EntityFramework.Repository;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {

        }

        public IQueryable CustomerReport() //buranın senaryosu tamamen bize ait, bu yazılan kural olarak yazılmadı.
        {
            return dbSet.AsQueryable();
        }
    }
}
