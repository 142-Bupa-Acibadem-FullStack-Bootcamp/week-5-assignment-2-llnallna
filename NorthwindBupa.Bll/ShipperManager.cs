﻿using Microsoft.Extensions.DependencyInjection;
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
    public class ShipperManager : BllBase<Shipper, DtoShipper>, IShipperService

    {
        public readonly IShipperRepository shipperRepository;
        public ShipperManager(IServiceProvider service) : base(service)
        {

        }
    }  
}
