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
    public class RegionManager : GenericManager<Region, DtoRegion>, IRegionService
    {
        //IRegionRepository
        public IQueryable<DtoRegion> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
