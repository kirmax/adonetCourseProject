using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    public class Purchase
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime datePurchased { get; set; }
        public DateTime dateShiped { get; set; }


        public virtual Supplier Supplier { get; set; }

        public virtual Product Product { get; set; }
    }
}
