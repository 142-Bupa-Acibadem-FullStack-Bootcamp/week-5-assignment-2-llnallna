using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindBupa.Entity.Base;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.IBase;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using NorthwindBupa.WebApi.Base;

namespace NorthwindBupa.WebApi.Controllers
{ //uygulama.patika.com/api/order
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ApiBaseController<IOrderService, Order, DtoOrder>
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService orderService) : base(orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet("VeriGetir")]
        public IResponse<bool> VeriGetir()
        {
            orderService.OrderReport(1);

            return new Response<bool>
            {
            };
        }

    }
}
