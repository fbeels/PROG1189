using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IPurchaseOrder
    {
         int PurchaseOrderID { get; set; }
         int EmployeeID { get; set; }

         DateTime OrderDate { get; set; }
         double SubTotal { get; set; }
         double Tax { get; set; }
         OrderStatus Status { get; set; }
        int lastupdated { get; set; }
    }
}
