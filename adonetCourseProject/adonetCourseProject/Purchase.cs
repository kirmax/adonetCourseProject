using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    public class Purchase
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DatePurchased { get; set; } 
        public DateTime DateShiped { get; set; }
        public string DeliveryCompany { get; set; }
        
      
        public virtual Supplier Supplier { get; set; }

        public virtual Product Product { get; set; }
        
        [NotMapped]
        
        public string DateP => DatePurchased.ToLongDateString();
        public string DateS => DateShiped.ToLongDateString();
    }
}
