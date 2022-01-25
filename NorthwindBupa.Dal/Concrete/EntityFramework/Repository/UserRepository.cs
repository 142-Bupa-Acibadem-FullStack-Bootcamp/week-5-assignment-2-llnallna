using Microsoft.EntityFrameworkCore;
using NorthwindBupa.Dal.Abstract;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Dal.Concrete.EntityFramework.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public User Login(User login)
        {
            // var user = dbSet.Where(x=>x.UserCode == login.UserCode && x.Password == login.Password).SingleOrDefault();

            var user = dbSet.FirstOrDefault(x => x.UserCode == login.UserCode && x.Password == login.Password);
            return user;
        }        
    }
}
