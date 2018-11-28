using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    class Purchase
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime datePurchased { get; set; }
        public DateTime dateShiped { get; set; }
        public Supplier SupplierId { get; set; }
        public Product ProductId { get; set; }
    }
}
