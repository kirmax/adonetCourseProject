using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace adonetCourseProject
{
    class WarehouseRepository : IRepository<Warehouse>
    {
        private DatabaseContext ctx = new DatabaseContext();

        static WarehouseRepository instance = null;

        public WarehouseRepository() { }

        public static WarehouseRepository GetInstance()
        {
            if (instance is null)
                instance = new WarehouseRepository();
            return instance;
        }
        
        public void Create(Warehouse item)
        {
 
                ctx.Warehouse.Add(item);

                ctx.Entry(item).State = EntityState.Added;
                ctx.SaveChanges();
            
        }

        public void Delete(int id)
        {
            
                Warehouse whToDelete = ctx.Warehouse.ToList().FirstOrDefault(w => w.Id == id);
                
                ctx.Warehouse.Remove(whToDelete);

                ctx.Entry(whToDelete).State = EntityState.Deleted;
                ctx.SaveChanges();
          
        }

        public Warehouse Get(int id)
        {
    
               return ctx.Warehouse.ToList().FirstOrDefault(w => w.Id == id);
 
        }

        public IEnumerable<Warehouse> GetAll()
        {
            
                return ctx.Warehouse.ToList();
            
        }

        public void Update(Warehouse item)
        {
                Warehouse warehouse = Get(item.Id);
                if (warehouse != null)
                {
                    warehouse.Quantity = item.Quantity;
                    warehouse.Product.Name = item.Product.Name;
                    warehouse.Product.Price = item.Product.Price;
                    warehouse.Product.Weight = item.Product.Weight;
                    warehouse.Product.Description = item.Product.Description;

                    ctx.Entry(warehouse).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
        }
    }
}
