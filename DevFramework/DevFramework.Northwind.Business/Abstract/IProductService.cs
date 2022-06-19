using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.Business.Abstract
{
    [ServiceContract]
    public interface IProductService : IEnumerable
    {
        [OperationContract]
        List<Product> GetAll();
        [OperationContract]
        Product GetById(int id);
        [OperationContract]
        Product Add(Product product);
        [OperationContract]
        Product Update(Product product);
        [OperationContract]
        void TransactionalOperation(Product product1 ,Product product2 );
    }
}
