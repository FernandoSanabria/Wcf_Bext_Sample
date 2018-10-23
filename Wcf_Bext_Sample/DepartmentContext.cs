using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Wcf_Bext_Sample
{
    public class DepartmentContext : DbContext

    {
        public DbSet<Department> Departments { get; set; }
        public DepartmentContext() : base("DepartmentCS")
        {

        }

    }
}