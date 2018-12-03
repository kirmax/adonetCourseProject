using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
           Database.SetInitializer(new DBInitializer());
        }
        public DatabaseContext() : base("Connection")
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Position> Positions { get; set; }


    }
}
