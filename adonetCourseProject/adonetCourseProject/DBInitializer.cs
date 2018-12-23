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
            //context.Accounts.Add(new Account { Login = "admin", Password = MD5Hash.GetMD5Hash("admin") });
            //context.SaveChanges();
            //context.Positions.Add(new Position { Name = "AdminPos", Avaibility = false, Description = " " });
            //context.SaveChanges();
            context.Employees.Add(new Employee { FirstName = "Akakiy", Salary = 10000, Reward = 0, Birthdate = DateTime.Parse("2004/04/15"), Account = new Account { Login = "ceo", Password = MD5Hash.GetMD5Hash("ceo") }, Position = new Position { Name = "CEO"} }); /*new Account { Login = "ivan01", Password = MD5Hash.GetMD5Hash("ceo") }*/
            context.Employees.Add(new Employee { FirstName = "Ivan", Salary = 2000, Reward = 1, Birthdate = DateTime.Parse("1956/04/15").Date, Account = new Account { Login = "ship", Password = MD5Hash.GetMD5Hash("ship") }, Position = new Position { Name = "ShipmentsDepartment"} });
            context.Employees.Add(new Employee { FirstName = "Denis", Salary = 3000, Reward = 2, Birthdate = DateTime.Parse("1967/04/15").Date, Account = new Account { Login = "wareh", Password = MD5Hash.GetMD5Hash("wareh") }, Position = new Position { Name = "WarehouseWorker"} });
            context.Employees.Add(new Employee { FirstName = "Kirill", Salary = 1500, Reward = 1, Birthdate = DateTime.Parse("1945/04/15").Date, Account = new Account { Login = "purch", Password = MD5Hash.GetMD5Hash("purch") },/*Photo = Employee.GetImageBytes(@"C:\Users\rudni\OneDrive\Рабочий стол\сомонеразвите.jpg"),*/ Position = new Position { Name = "PurchasesDepartment" } });

            context.Purchases.Add(new Purchase { Quantity = 5, DatePurchased = DateTime.Now, DateShiped = DateTime.Now, Product = new Product { Name = "Banana", Price = 1000, Weight = 500 }, Supplier = new Supplier { CompanyName = "kek", ContactName = "kek", Phone = "0404044040" } });
            context.Purchases.Add(new Purchase { Quantity = 5, DatePurchased = DateTime.Now, DateShiped = DateTime.Now, Product = new Product { Name = "Gamno", Price = 1000, Weight = 500 }, Supplier = new Supplier { CompanyName = "kek", ContactName = "kek", Phone = "0404044040" } });
            context.Purchases.Add(new Purchase { Quantity = 5, DatePurchased = DateTime.Now, DateShiped = DateTime.Now, Product = new Product { Name = "Jopa", Price = 1000, Weight = 500 }, Supplier = new Supplier { CompanyName = "kek", ContactName = "kek", Phone = "0404044040" } });

            context.Shipments.Add(new Shipment { Quantity = 5,ShipmentDate = DateTime.Now, Product = new Product { Name = "Banana", Price = 1000, Weight = 500 }, Customer = new Customer { CompanyName = "kek", ContactName = "kek", Phone = "0404044040" } });


            context.Warehouse.Add(new Warehouse { Product = new Product { Name = "Banana", Price = 1000, Weight = 500 }, Quantity = 5 });
            context.SaveChanges();
            
        }
    }
}
