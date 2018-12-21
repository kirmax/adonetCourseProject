using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    public class Shipment
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime ShipmentDate { get; set; }
        public int Quantity { get; set; }
        public string DeliveryCompany { get; set; }

        public virtual Product Product { get; set; }

        public virtual Customer Customer { get; set; }

        [NotMapped]

        public string DateShipment => ShipmentDate.ToLongDateString();
    }
}
