using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace DevFramewor.Northwind.Entities.Concrete
{
    public class UserRole :IEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
}
