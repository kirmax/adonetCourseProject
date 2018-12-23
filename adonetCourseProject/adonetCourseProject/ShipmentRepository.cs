using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    class ShipmentRepository : IRepository<Shipment>
    {

        private DatabaseContext ctx = new DatabaseContext();

        static ShipmentRepository instance = null;

        public ShipmentRepository() { }

        public static ShipmentRepository GetInstance()
        {
            if (instance is null)
                instance = new ShipmentRepository();
            return instance;
        }

        public void Create(Shipment item)
        {
            
                ctx.Shipments.Add(item);

                ctx.Entry(item).State = EntityState.Added;
                ctx.SaveChanges();
            
        }

        public void Delete(int id)
        {

            Shipment shipmentToDelete = Get(id);

            if (shipmentToDelete != null)
            {
                ctx.Shipments.Remove(shipmentToDelete);

                ctx.Entry(shipmentToDelete).State = EntityState.Deleted;
                ctx.SaveChanges();
            }

            
        }

        public Shipment Get(int id)
        {
            
                return ctx.Shipments.FirstOrDefault(s => s.Id == id);

        }

        public IEnumerable<Shipment> GetAll()
        {
            
                return ctx.Shipments.ToList();
            
        }

        public void Update(Shipment item)
        {

                Shipment shipment = Get(item.Id); //ctx.Shipments.FirstOrDefault(s => s.Id == item.Id);
                if (shipment != null)
                {
                    shipment.Product = item.Product;
                    shipment.Price = item.Price;
                    shipment.Quantity = item.Quantity;
                    shipment.ShipmentDate = item.ShipmentDate;
                    shipment.DeliveryCompany = item.DeliveryCompany;
                    shipment.Customer = item.Customer;


                    ctx.Entry(shipment).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            
        }
    }
}
