﻿using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class ProductSalesFor1997Manager : GenericManager<ProductSalesFor1997, DtoProductSalesFor1997>, IProductSalesFor1997Service
    {
        //IProductSalesFor1997Repository
        public IQueryable<DtoProductSalesFor1997> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
