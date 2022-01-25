using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using NorthwindBupa.WebApi.Base;

namespace NorthwindBupa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ApiBaseController<IOrderDetailService, OrderDetail, DtoOrderDetail>
    {

        public OrderDetailController(IOrderDetailService service) : base(service)
        {

        }
    }
}
