using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using FluentValidation;
using Ninject.Modules;

namespace DevFramework.Northwind.Business.DependencyResolves.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}
