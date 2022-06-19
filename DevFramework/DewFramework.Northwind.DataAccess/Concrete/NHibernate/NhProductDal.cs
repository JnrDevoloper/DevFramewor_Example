using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.ComplexTypes;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess.NHihabernate;
using DewFramework.Northwind.DataAccess.Abstract;

namespace DewFramework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>,IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> getProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                    join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                    select new ProductDetail
                    {
                        ProductId = p.ProductId,
                        CategoryName = c.CategoryName,
                        ProductName = p.ProductName
                    };
                return result.ToList();
            }
        }
    }
}
