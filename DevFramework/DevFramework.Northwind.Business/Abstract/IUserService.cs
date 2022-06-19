using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.ComplexTypes;
using DevFramewor.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.Business.Abstract
{
    public interface IUserService 
    {
        User GetByUserNameAndPassword(string userName, string password);
        List<UserRoleItem> GetUserRoles(User user);
    }
}
