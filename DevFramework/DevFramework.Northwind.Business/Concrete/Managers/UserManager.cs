using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.ComplexTypes;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Northwind.Business.Abstract;
using DewFramework.Northwind.DataAccess.Abstract;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class UserManager :IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName & u.Password == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
