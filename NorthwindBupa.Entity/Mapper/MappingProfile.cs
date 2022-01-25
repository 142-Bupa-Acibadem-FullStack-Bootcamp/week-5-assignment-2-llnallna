using AutoMapper;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
            CreateMap<User, DtoLoginUser>().ReverseMap();
            CreateMap<User, DtoLogin>().ReverseMap();
        }

    }
}
