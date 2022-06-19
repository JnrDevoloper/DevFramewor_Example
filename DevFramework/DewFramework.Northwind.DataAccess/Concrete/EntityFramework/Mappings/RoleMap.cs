using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramewor.Northwind.Entities.Concrete;

namespace DewFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RoleMap :EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable(@"Roles", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
        }
    }
}
