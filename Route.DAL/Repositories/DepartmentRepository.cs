using Route.DAL.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Route.DAL.Repositories
{
    public class DepartmentRepository(AppDbContext context) : IDepartmentRepository
    {
        public IEnumerable<Department> GetAll(bool withTracking = false)
        {
            if (withTracking)
                return context.Departments.ToList();
            else
                return context.Departments.AsNoTracking().ToList();
        }

        public Department? GetById(int id)
        {
            return context.Departments.Find(id);
        }

        public int Add(Department department)
        {
            context.Departments.Add(department);
            return context.SaveChanges();
        }

        public int Update(Department department)
        {
            context.Departments.Update(department);
            return context.SaveChanges();
        }

        public int Delete(Department department)
        {
            context.Departments.Remove(department);
            return context.SaveChanges();
        }
    }
}
