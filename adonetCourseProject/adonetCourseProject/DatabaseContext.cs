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
        public DbSet<Account> Accounts { get; set; };
    }
}
