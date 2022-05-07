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
    public class CategorySalesFor1997Repository : GenericRepository<CategorySalesFor1997>, ICategorySalesFor1997Repository
    {
        public CategorySalesFor1997Repository(DbContext context) : base(context)
        {

        }

        public IQueryable<CategorySalesFor1997> GetTotalReport()
        {
            return dbset.AsQueryable();
        }
    }
}
