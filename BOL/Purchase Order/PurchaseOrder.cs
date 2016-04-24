using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using BOL.Purchase_Order_Item;


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

        public double calculateSubtotal()
        {
            double subtotal = 0.0;
            foreach (PurchaseOrderItem item in Items)
            {
                subtotal += item.calculateSubtotal();
            }

            return subtotal;
        }

        public double calculateTax()
        {
            double subtotal = calculateSubtotal();
            return subtotal * tax;
        }

        public double calculateTotal()
        {
            double subtotal = calculateSubtotal();
            double taxamnt = calculateTax();
            return subtotal * taxamnt;
        }

    }
}
