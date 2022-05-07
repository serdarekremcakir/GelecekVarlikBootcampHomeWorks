﻿using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.Entitiyframework.Repository
{
    public class OrderDetailsExtendedRepository : GenericRepository<OrderDetailsExtended>, IOrderDetailsExtendedRepository
    {
        public OrderDetailsExtendedRepository(DbContext context) : base(context)
        {

        }

        public IQueryable<OrderDetailsExtended> GetTotalReport()
        {
            return dbset.AsQueryable();
        }
    }
}
