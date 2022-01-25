using Microsoft.EntityFrameworkCore;
using NorthwindBupa.Dal.Abstract;
using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Models;
using NorthwindBupa.Interface;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindBupa.Dal.Concrete.EntityFramework.Repository
{
    public class AlphabeticalListOfProductRepository : GenericRepository<AlphabeticalListOfProduct>, IAlphabeticalListOfProductRepository
    {
        public AlphabeticalListOfProductRepository(DbContext context) : base(context)
        {
        }
    }
}
