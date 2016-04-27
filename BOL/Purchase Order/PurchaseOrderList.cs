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



        static public List<PurchaseOrderList> Create(int EmployeeID, int ID = -1, DateTime? startdate = null, DateTime? enddate = null)
        {
            return RePackager(PurchaseOrderSQL.searchPO(EmployeeID, ID, startdate, enddate));
        }


        static private List<PurchaseOrderList> RePackager(DataTable dt)
        {
            List<PurchaseOrderList> myList = new List<PurchaseOrderList>();

            foreach (DataRow orders in dt.Rows)
            {
                PurchaseOrderList x = new PurchaseOrderList();
                x.EmployeeID = (int)orders[5];
                x.Status = (OrderStatus) int.Parse(orders[2].ToString());
                x.Total = (double.Parse(orders[3].ToString())) + (double.Parse(orders[4].ToString()));
                x.OrderDate = DateTime.Parse(orders[1].ToString());
                x.PurchaseOrderID = (int) orders[0];
                myList.Add(x);
            }
            return myList;
        }
    }
}
