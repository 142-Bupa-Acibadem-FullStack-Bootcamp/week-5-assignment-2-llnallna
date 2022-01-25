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
    public class OrderManager : BllBase<Order, DtoOrder>, IOrderService

    {
        public readonly IOrderRepository orderRepository;
        public OrderManager(IServiceProvider service) : base(service)
        {
            orderRepository = service.GetService<IOrderRepository>();
        }
        public IQueryable OrderReport(int orderId)
        {
           return orderRepository.OrderReport(orderId);
        }
    }
}
