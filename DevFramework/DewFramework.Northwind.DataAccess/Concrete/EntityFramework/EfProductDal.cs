using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.ComplexTypes;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess.EntityFramework;
using DewFramework.Northwind.DataAccess.Abstract;

namespace DewFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public object GetList()
        {
            throw new NotImplementedException();
        }

        public List<ProductDetail> getProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on p.CategoryId equals c.CategoryId
                    select new ProductDetail
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName
                    };

                return result.ToList();
            }
            
        }
    }
}
