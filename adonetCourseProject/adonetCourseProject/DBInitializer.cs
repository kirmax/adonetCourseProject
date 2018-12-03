using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    class DBInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.Accounts.Add(new Account { Login = "admin", Password = "admin" });
            context.SaveChanges();
            context.Positions.Add(new Position { Name = "Admin", Avaibility = false, Description = " " });
            context.SaveChanges();
            context.Employees.Add(new Employee { FirstName = "Admin", Salary = 1000, Reward = 1, Birthdate= DateTime.Now, Account = context.Accounts.First(), Position = context.Positions.First() });

            context.SaveChanges();
        }
    }
}
