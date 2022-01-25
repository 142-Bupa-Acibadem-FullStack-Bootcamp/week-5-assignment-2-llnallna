using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.IBase;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Interface
{
    public interface IUserService : IGenericService<User, DtoUser>
    {
        IResponse<DtoUserToken> Login(DtoLogin login);
        IResponse<DtoRegister> Register(DtoRegister register);
    }
}
