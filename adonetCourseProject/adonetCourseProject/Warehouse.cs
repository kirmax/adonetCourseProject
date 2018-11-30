using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    public class Warehouse
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public Product Product { get; set; }
    }
}
