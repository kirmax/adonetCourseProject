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

                if (item.FirstName != null)
                {
                    if (item.Position.Name.Equals("CEO") || item.Position.Name.Equals("HR") || item.Position.Name.Equals("ShipmentsDepartment") || item.Position.Name.Equals("PurchasesDepartment") || item.Position.Name.Equals("WarehouseWorker"))
                    {
                        Random rand = new Random();
                        employee.Account = employee.Account == null ? new Account { Login = item.FirstName + rand.Next(10, 255).ToString(), Password = MD5Hash.GetMD5Hash(item.Position.Name.ToLower().Substring(0, 2) + rand.Next(111111, 999999).ToString()) } : item.Account;
                    }
                    ctx.Entry(employee).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }

        }
    }
}
