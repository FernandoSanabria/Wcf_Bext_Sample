using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf_Bext_Sample
{
    public class Service1 : IService1
    {
        public void DeleteDep(string Id)
        {
            int k = Convert.ToInt32(Id);
            DepartmentContext po = new DepartmentContext();
            var c = (from per in po.Departments
                     where per.Id == k
                     select per).First();
            po.Departments.Remove(c);
            po.SaveChanges();


        }

        public IEnumerable<Department> GetDep()
        {
            List<Department> li = new List<Department>();
            DepartmentContext po = new DepartmentContext();
            li = po.Departments.ToList();
            return li;

        }

        public void InsertDep(Department pobj)
        {
            DepartmentContext po = new DepartmentContext();
            po.Departments.Add(pobj);
            po.SaveChanges();
        }

        public void UpdateDep(Department pobj)
        {
            DepartmentContext po = new DepartmentContext();
            var c = (from per in po.Departments
                     where per.Id == pobj.Id
                     select per).First();
            c.Departamento = pobj.Departamento;
            c.Capital = pobj.Capital;
            po.SaveChanges();
        }
    }
}
