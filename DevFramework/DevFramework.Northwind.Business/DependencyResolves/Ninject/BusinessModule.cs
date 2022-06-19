using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;
using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Core.DataAccess.NHihabernate;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.Concrete.Managers;
using DewFramework.Northwind.DataAccess.Abstract;
using DewFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DewFramework.Northwind.DataAccess.Concrete.NHibernate;
using DewFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Ninject.Modules;

namespace DevFramework.Northwind.Business.DependencyResolves.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope(); ;

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind(typeof(IQueryableRepositorys<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();

            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
