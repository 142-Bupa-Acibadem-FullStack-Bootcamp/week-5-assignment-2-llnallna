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
    public class EmployeeTerritoryManager : BllBase<EmployeeTerritory, DtoEmployeeTerritory>, IEmployeeTerritoryService

    {
        public readonly IEmployeeTerritoryRepository employeeTerritoryRepository;
        public EmployeeTerritoryManager(IServiceProvider service) : base(service)
        {

        }
    }  
}
