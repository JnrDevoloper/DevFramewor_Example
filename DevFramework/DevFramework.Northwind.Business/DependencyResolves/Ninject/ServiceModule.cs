using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Utillities.Common;
using DevFramework.Northwind.Business.Abstract;
using Ninject.Modules;

namespace DevFramework.Northwind.Business.DependencyResolves.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChanel());
        }
    }
}
