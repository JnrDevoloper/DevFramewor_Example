using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.DependencyResolves.Ninject;

/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService:IProductService
{
    public ProductService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }

    public Product GetById(int id)
    {
        return _productService.GetById(id);
    }

    public Product Add(Product product)
    { 
        return _productService.Add(product);
    }

    public Product Update(Product product)
    {
       return _productService.Update(product);
    }

    public void TransactionalOperation(Product product1, Product product2)
    {
         _productService.TransactionalOperation(product1,product2);
    }
}