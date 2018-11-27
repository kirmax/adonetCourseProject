using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    class Warehouse
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public Product ProductId { get; set; }
    }
}
