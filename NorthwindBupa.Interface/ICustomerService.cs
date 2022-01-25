using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Interface
{
    public interface ICustomerService : IGenericService<Customer, DtoCustomer>
    {
        IQueryable CustomerReport();
    }
}
