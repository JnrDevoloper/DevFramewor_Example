using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess.EntityFramework;
using DewFramework.Northwind.DataAccess.Abstract;

namespace DewFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
