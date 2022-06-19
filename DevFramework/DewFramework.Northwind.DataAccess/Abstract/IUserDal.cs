using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.ComplexTypes;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess;

namespace DewFramework.Northwind.DataAccess.Abstract
{
    public interface IUserDal :IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}
