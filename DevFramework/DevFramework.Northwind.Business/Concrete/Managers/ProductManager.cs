using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Business.ValidationRules.FluentValidation;
using DewFramework.Northwind.DataAccess.Abstract;
using DevFramework.Core.Aspects.Postsharp;
using DevFramework.Core.DataAccess;
using System.Transactions;
using DevFramework.Core.Aspects.Postsharp.CacheAspects;
using DevFramework.Core.Aspects.Postsharp.ExceptionAspects;
using DevFramework.Core.Aspects.Postsharp.LogAspects;
using DevFramework.Core.Aspects.Postsharp.PerformanceAspects;
using DevFramework.Core.Aspects.Postsharp.TransactionAspects;
using DevFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using DevFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using System.Threading;
using AutoMapper;
using DevFramework.Core.Aspects.Postsharp.Authorizationaspects;
using DevFramework.Core.CrossCuttingConcerns.Security.Web;
using DevFramework.Core.Utillities.Mappings;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager :IProductService
    {
        private IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal ,IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(2)]
        //[SecuredOperation(Roles= "Admin,Editor,Student")]
        public List<Product> GetAll()
        {
            var products = _mapper.Map<List<Product>>(_productDal.GetList());
            return products;
        }

        

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }
        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(ProductValidator))]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDal.Add(product1);
            //busines code
            _productDal.Update(product2);
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
