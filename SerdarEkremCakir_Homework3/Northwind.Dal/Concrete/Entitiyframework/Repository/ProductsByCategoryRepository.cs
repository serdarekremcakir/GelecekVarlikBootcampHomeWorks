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
    public class ProductsByCategoryRepository : GenericRepository<ProductsByCategory>, IProductsByCategoryRepository
    {
        public ProductsByCategoryRepository(DbContext context) : base(context)
        {

        }

        public IQueryable<ProductsByCategory> GetTotalReport()
        {
            return dbset.AsQueryable();
        }
    }
}
