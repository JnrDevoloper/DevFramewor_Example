using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess;

namespace DewFramework.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}
