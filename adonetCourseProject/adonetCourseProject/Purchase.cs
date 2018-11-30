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


        public Supplier Supplier { get; set; }

        public Product Product { get; set; }
    }
}
