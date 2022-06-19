using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess.NHihabernate;
using DewFramework.Northwind.DataAccess.Abstract;

namespace DewFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal : NhEntityRepositoryBase<Category>,ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
