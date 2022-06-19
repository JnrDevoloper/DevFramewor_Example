using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Northwind.Business.Concrete.Managers;
using DewFramework.Northwind.DataAccess.Abstract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using FluentValidation;

namespace DevFramework.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTest
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}
