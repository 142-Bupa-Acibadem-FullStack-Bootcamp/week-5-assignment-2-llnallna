using NorthwindBupa.Bll.Base;
using NorthwindBupa.Dal.Abstract;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Bll
{
    public class CustomerManager : BllBase<Customer, DtoCustomer>, ICustomerService

    {
        public readonly ICustomerRepository customerRepository;
        public CustomerManager(IServiceProvider service) : base(service)
        {

        }
       
        public IQueryable CustomerReport()
        {
            return customerRepository.CustomerReport();
        }
    }
}
