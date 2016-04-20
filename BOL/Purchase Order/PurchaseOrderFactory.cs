using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTypes;
using SQLLayer;

namespace BOL.Purchase_Order
{
   static class PurchaseOrderFactory
    {
        static public PurchaseOrder Create()
        {
            return new PurchaseOrder();
        }


        static public PurchaseOrder Create(int PO_ID)
        {
            DataTable x = new DataTable();

            return RePackager(x);
        }

        static private PurchaseOrder RePackager(DataTable dt)
        {
            PurchaseOrder x = new PurchaseOrder();

            foreach (DataRow row in dt.Rows)
            {
                x.PurchaseOrderID = int.Parse(row["poid"].ToString());
                x.OrderDate = DateTime.Parse(row["orderdate"].ToString());
                x.Tax = double.Parse(row["tax"].ToString());
                x.SubTotal = double.Parse(row["subtotal"].ToString());
                x.Status = (OrderStatus) int.Parse(row["orderdate"].ToString());
                x.EmployeeID = int.Parse(row["orderdate"].ToString());
            }

            return x;
        }
    }
}
