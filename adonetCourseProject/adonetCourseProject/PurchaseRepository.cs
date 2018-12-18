using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    class PurchaseRepository : IRepository<Purchase>
    {
        private DatabaseContext ctx;

        static PurchaseRepository instance = null;

        PurchaseRepository() { }

        public static PurchaseRepository GetInstance()
        {
            if (instance is null)
                instance = new PurchaseRepository();
            return instance;
        }


        public void Create(Purchase item)
        {
            using (ctx = new DatabaseContext())
            {
                ctx.Purchases.Add(item);

                ctx.Entry(item).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public Purchase Get(int id)
        {
            using (ctx = new DatabaseContext())
            {
                return ctx.Purchases.Find(id);
            }

        }

        public IEnumerable<Purchase> GetAll()
        {
            using (ctx = new DatabaseContext())
            {
                return ctx.Purchases.ToList();
            }
        }

        public void Delete(int id)
        {
            using (ctx = new DatabaseContext())
            {
                Purchase purchase = ctx.Purchases.Find(id);

                if (purchase != null)
                {
                    ctx.Purchases.Remove(purchase);

                    ctx.Entry(purchase).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }

            }
        }

        public void Update(Purchase item)
        {
            Purchase purchase = ctx.Purchases.Find(item.Id);
            if (purchase != null)
            {
                purchase.Price = item.Price;
                purchase.Product = item.Product;
                purchase.Quantity = item.Quantity;
                purchase.DatePurchased = item.DatePurchased;
                purchase.DateShiped = item.DateShiped;
                purchase.DeliveryCompany = item.DeliveryCompany;
                purchase.Supplier = item.Supplier;
                

                ctx.Entry(purchase).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
