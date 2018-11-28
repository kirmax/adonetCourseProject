using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    class Shipment
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime ShipmentDate { get; set; }
        public int Quantity { get; set; }
        public string DeliveryCompany { get; set; }
        public Product ProductId { get; set; }
        public Customer CustomerId { get; set; }

    }
}
