using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.ComplexTypes;
using DevFramewor.Northwind.Entities.Concrete;
using DevFramework.Core.DataAccess.EntityFramework;
using DewFramework.Northwind.DataAccess.Abstract;
using Microsoft.Build.Tasks;

namespace DewFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from ur in context.UserRole
                    join r in context.Roles
                        on ur.UserId equals user.Id
                    where ur.UserId == user.Id
                    select new UserRoleItem {RoleName = r.Name};
                return result.ToList();
            }
        }
    }
}
