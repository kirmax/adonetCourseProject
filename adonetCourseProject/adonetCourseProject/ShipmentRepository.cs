﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    class ShipmentRepository : IRepository<Shipment>
    {

        private DatabaseContext ctx;

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
            using (ctx = new DatabaseContext())
            {
                ctx.Shipments.Add(item);

                ctx.Entry(item).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (ctx = new DatabaseContext())
            {
                Shipment shipmentToDelete = ctx.Shipments.Find(id);

                if (shipmentToDelete != null)
                {
                    ctx.Shipments.Remove(shipmentToDelete);

                    ctx.Entry(shipmentToDelete).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }

            }
        }

        public Shipment Get(int id)
        {
            using (ctx = new DatabaseContext())
            {
                return ctx.Shipments.Find(id);
            }
        }

        public IEnumerable<Shipment> GetAll()
        {
            using (ctx = new DatabaseContext())
            {
                return ctx.Shipments.ToList();
            }
        }

        public void Update(Shipment item)
        {
            using (ctx = new DatabaseContext())
            {
                Shipment shipment = ctx.Shipments.FirstOrDefault(s => s.Id == item.Id);
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
}
