﻿using System;
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
            //context.Accounts.Add(new Account { Login = "admin", Password = MD5Hash.GetMD5Hash("admin") });
            //context.SaveChanges();
            //context.Positions.Add(new Position { Name = "AdminPos", Avaibility = false, Description = " " });
            //context.SaveChanges();
            context.Employees.Add(new Employee { FirstName = "Akakiy", Salary = 10000, Reward = 0, Birthdate = DateTime.Parse("2004/04/15"), Account = new Account { Login = "ceo", Password = MD5Hash.GetMD5Hash("ceo") }, Position = new Position { Name = "CEO", Avaibility = false, Description = "Full control" } }); /*new Account { Login = "ivan01", Password = MD5Hash.GetMD5Hash("ceo") }*/
            context.Employees.Add(new Employee { FirstName = "Ivan", Salary = 2000, Reward = 1, Birthdate = DateTime.Parse("1956/04/15").Date, Account = null, Position = new Position { Name = "Worker", Avaibility = false, Description = "No control" } });
            context.Employees.Add(new Employee { FirstName = "Denis", Salary = 3000, Reward = 2, Birthdate = DateTime.Parse("1967/04/15").Date, Account = null, Position = new Position { Name = "WarehouseWorker", Avaibility = false, Description = "No control" } });
            context.Employees.Add(new Employee { FirstName = "Kirill", Salary = 1500, Reward = 1, Birthdate = DateTime.Parse("1945/04/15").Date, Account = null,/*Photo = Employee.GetImageBytes(@"C:\Users\rudni\OneDrive\Рабочий стол\сомонеразвите.jpg"),*/ Position = new Position { Name = "Director", Avaibility = false, Description = "Full control <3"} });
            
            
            context.SaveChanges();
        }
    }
}
