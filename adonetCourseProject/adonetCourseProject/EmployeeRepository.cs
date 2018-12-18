using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace adonetCourseProject
{
    class EmployeeRepository : IRepository<Employee>
    {
        private DatabaseContext ctx;

        static EmployeeRepository instance = null;

        public EmployeeRepository() { }

        public static EmployeeRepository GetInstance()
        {
            if (instance is null)
                instance = new EmployeeRepository();
            return instance;
        }
        

        public void Create(Employee item)
        {
            using (ctx = new DatabaseContext())
            {
                ctx.Employees.Add(item);

                ctx.Entry(item).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public Employee Get(int id)
        {
            using (ctx = new DatabaseContext())
            {
                return ctx.Employees.Find(id);
            }

        }

        public IEnumerable<Employee> GetAll()
        {
            using (ctx = new DatabaseContext())
            {
                return ctx.Employees.Include(e => e.Position).ToList();
            }
        }

        public void Delete(int id)
        {
            using (ctx = new DatabaseContext())
            {
                Employee employee = ctx.Employees.Find(id);

                if (employee != null)
                {
                    ctx.Employees.Remove(employee);

                    ctx.Entry(employee).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
                    
            }
        }

        public void Update(Employee item)
        {
            using (ctx = new DatabaseContext())
            { 
                Employee employee = ctx.Employees.Find(item.Id - 1);
                if (employee != null)
                {
                    employee.Photo = item.Photo;
                    employee.FirstName = item.FirstName;
                    employee.MiddleName = item.MiddleName;
                    employee.LastName = item.LastName;
                    employee.Address = item.Address;
                    employee.Phone = item.Phone;
                    employee.Birthdate = item.Birthdate;
                    employee.Email = item.Email;
                    employee.Salary = item.Salary;
                    employee.Reward = item.Reward;
                    employee.Position.Name = item.Position.Name;

                    ctx.Entry(employee).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
