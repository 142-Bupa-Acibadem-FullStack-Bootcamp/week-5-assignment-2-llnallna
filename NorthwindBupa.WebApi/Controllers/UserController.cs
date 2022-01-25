using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindBupa.Entity.Base;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.IBase;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using NorthwindBupa.WebApi.Base;
using System;

namespace NorthwindBupa.WebApi.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService) 
        {
            this.userService = userService;
        }
        [HttpPost]
        [AllowAnonymous]
        public IResponse<DtoUserToken> Login(DtoLogin login)
        {
            try
            {
                return userService.Login(login);
            }
            catch (Exception ex)
            {
                return new Response<DtoUserToken>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public IResponse<DtoRegister> Register(DtoRegister register)
        {
            try
            {
                return userService.Register(register);
            }
            catch (Exception ex)
            {
                return new Response<DtoRegister>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}

