using Microsoft.Extensions.DependencyInjection;
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
    public class EmployeeManager : BllBase<Employee, DtoEmployee>, IEmployeeService

    {
        public readonly IEmployeeRepository employeeRepository;
        public EmployeeManager(IServiceProvider service) : base(service)
        {

        }
    }  
}
