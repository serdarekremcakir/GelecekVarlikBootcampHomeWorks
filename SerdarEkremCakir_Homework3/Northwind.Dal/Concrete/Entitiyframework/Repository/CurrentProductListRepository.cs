using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.Entitiyframework.Repository
{
    public class CurrentProductListRepository : GenericRepository<CurrentProductList>, ICurrentProuctListRepository
    {
        public CurrentProductListRepository(DbContext context) : base(context)
        {

        }

        public IQueryable<CurrentProductList> GetTotalReport()
        {
            return dbset.AsQueryable();
        }
    }
}
