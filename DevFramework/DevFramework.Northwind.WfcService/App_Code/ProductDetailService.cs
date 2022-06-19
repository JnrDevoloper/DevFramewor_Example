using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolves.Ninject;
using DevFramework.Northwind.Business.ServiceContract.Wcf;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService:IProductDetailService
{
    public ProductDetailService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}