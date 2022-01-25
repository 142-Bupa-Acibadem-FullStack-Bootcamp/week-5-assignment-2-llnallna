using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NorthwindBupa.Bll.Base;
using NorthwindBupa.Dal.Abstract;
using NorthwindBupa.Entity.Base;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.IBase;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Bll
{
    public class UserManager : BllBase<User, DtoUser>, IUserService
    {
        public readonly IUserRepository userRepository;
        IConfiguration configuration;

        public UserManager(IServiceProvider service, IConfiguration configuration) : base(service)
        {
            userRepository = service.GetService<IUserRepository>();
            this.configuration = configuration;
        }

        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            var user = userRepository.Login(ObjectMapper.Mapper.Map<User>(login));

            if (user != null)
            {
                var dtoUser = ObjectMapper.Mapper.Map<DtoLoginUser>(user);
                var token = new TokenManager(configuration).CreateAccessToken(dtoUser);

                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtoUser,
                    AccessToken = token
                };

                return new Response<DtoUserToken>
                {
                    Message = "Token is success!",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            }
            else
            {
                return new Response<DtoUserToken>
                {
                    Message = "UserCode or Password is wrong.",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }

        }




        public IResponse<DtoRegister> Register(DtoRegister dtoRegister)
        {
            bool saveChanges = true;
            var user = dtoRegister;
            var pass = MD5Manager.MD5Hash(user.Password);

            var userReg = new DtoRegister
            {
                UserCode = user.UserCode,
                UserName = user.UserName,
                UserLastName = user.UserLastName,
                Password = pass,
            };
            if (saveChanges)
                Save();
            try
            {
                return new Response<DtoRegister>
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userReg
                };
            }
            catch (Exception ex)
            {
                return new Response<DtoRegister>
                {
                    Message = $"Error : {ex.Message}",
                };
            }
        }
    }
}


