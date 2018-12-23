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
        private DatabaseContext ctx = new DatabaseContext();

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
            
                ctx.Employees.Add(item);

                ctx.Entry(item).State = EntityState.Added;
                ctx.SaveChanges();
            
        }

        public Employee Get(int id)
        {

            return ctx.Employees.FirstOrDefault(e => e.Id == id);
            

        }

        public IEnumerable<Employee> GetAll()
        {
            
                return ctx.Employees.Include(e => e.Position).ToList();
            
        }

        public void Delete(int id)
        {
            
                Employee employeeToDelete = Get(id);

                if (employeeToDelete != null)
                {
                    ctx.Employees.Remove(employeeToDelete);

                    ctx.Entry(employeeToDelete).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
                    
            
        }

        public void Update(Employee item)
        {
            
                Employee employee = Get(item.Id);
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
