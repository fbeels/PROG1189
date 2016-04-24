using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using SQLLayer;

namespace BOL.Purchase_Order
{
    public class PurchaseOrderList
    {
        public int PurchaseOrderID { get; set; }
        public int EmployeeID { get; set; }
        public OrderStatus Status { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }



        static public List<PurchaseOrderList>  Create(int ID = -1, DateTime? date = null)
        {
            return RePackager(PurchaseOrderSQL.searchPO(ID, date));
        }


        static private List<PurchaseOrderList>  RePackager(DataTable dt)
        {
            List<PurchaseOrderList> myList = new List<PurchaseOrderList>();

            foreach (PurchaseOrder orders in dt.Rows)
            {
                PurchaseOrderList x = new PurchaseOrderList();
                x.EmployeeID = orders.EmployeeID;
                x.Status = orders.Status;
                x.Total = orders.Total;
                x.OrderDate = orders.OrderDate;
                x.PurchaseOrderID = orders.PurchaseOrderID;
            }
            return myList;
        }
    }
}
