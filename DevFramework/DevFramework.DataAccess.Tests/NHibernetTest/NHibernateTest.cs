using DewFramework.Northwind.DataAccess.Concrete.EntityFramework;
using DewFramework.Northwind.DataAccess.Concrete.NHibernate;
using DewFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.DataAccess.Tests.NHibernetTest
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());

            var result = productDal.GetList(null);

            Assert.AreEqual(79, result.Count);

        }

        [TestMethod]

        public void Get_all_with_paramerter_returns_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            
            var result = productDal.GetList(p => p.ProductName.Contains("ab"));

            Assert.AreEqual(4,result.Count);
        }
    }

    
}
