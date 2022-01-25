using Microsoft.Extensions.DependencyInjection;
using NorthwindBupa.Bll.Base;
using NorthwindBupa.Dal.Abstract;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.IBase;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Bll
{
    public class CustomerDemographicManager : BllBase<CustomerDemographic, DtoCustomerDemographic>, ICustomerDemographicService

    {
        public readonly ICustomerDemographicRepository customerDemographicRepository;
        public CustomerDemographicManager(IServiceProvider service) : base(service)
        {

        }

        public IResponse<DtoCustomerDemographic> Add(DtoCustomerDemographic item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public new Task<DtoCustomerDemographic> AddAsync(DtoCustomerDemographic item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DtoCustomerDemographic item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(DtoCustomerDemographic item)
        {
            throw new NotImplementedException();
        }

        public DtoCustomerDemographic Update(DtoCustomerDemographic item)
        {
            throw new NotImplementedException();
        }

        public Task<DtoCustomerDemographic> UpdateAsync(DtoCustomerDemographic item)
        {
            throw new NotImplementedException();
        }

        IResponse<DtoCustomerDemographic> IGenericService<CustomerDemographic, DtoCustomerDemographic>.Find(int id)
        {
            throw new NotImplementedException();
        }

        IResponse<List<DtoCustomerDemographic>> IGenericService<CustomerDemographic, DtoCustomerDemographic>.GetAll()
        {
            throw new NotImplementedException();
        }

        IResponse<List<DtoCustomerDemographic>> IGenericService<CustomerDemographic, DtoCustomerDemographic>.GetAll(Expression<Func<CustomerDemographic, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }  
}
