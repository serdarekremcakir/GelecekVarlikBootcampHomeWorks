using Northwind.Entity.Dto;
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
    public class SupplierManager : GenericManager<Supplier, DtoSupplier>, ISupplierService
    {
        //ISupplierRepository
        public IQueryable<DtoSupplier> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
