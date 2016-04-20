using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTypes;

namespace BOL.Purchase_Order
{
   public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public int EmployeeID { get; set; }

        public DateTime OrderDate { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public OrderStatus Status { get; set; }

        public void test { }



    }
}
