using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using BOL.Purchase_Order_Item;
using SQLLayer;


namespace BOL.Purchase_Order
{
    [Serializable]
    public class PurchaseOrder : IPurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public int EmployeeID { get; set; }

        public DateTime OrderDate { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public OrderStatus Status { get; set; }
        public double Total { get; set; }


        public List<PurchaseOrderItem> Items { get; set; }

        const double tax = .13;


        private double subtotal;
        private double taxamnt;
        private double total;

        public double calculateSubtotal()
        {
            subtotal = 0;
            foreach (PurchaseOrderItem item in Items)
            {
                subtotal += item.calculateSubtotal();
            }

            return subtotal;
        }

        public double calculateTax()
        {
            taxamnt = subtotal * tax;
            return taxamnt;
        }

        public double calculateTotal()
        {
            total = subtotal + taxamnt;
            return total;
        }


        public static void closeOrder(PurchaseOrder PO)
        {
            PO.Status = OrderStatus.Closed;
            PurchaseOrderSQL.modifyPO(PO);
        }

        public static void markUnderReview(PurchaseOrder PO)
        {
            PO.Status = OrderStatus.UnderReview;
            PurchaseOrderSQL.modifyPO(PO);
        }

        public static void markPending(PurchaseOrder PO)
        {
            PO.Status = OrderStatus.Pending;
            PurchaseOrderSQL.modifyPO(PO);
        }
    }
}
