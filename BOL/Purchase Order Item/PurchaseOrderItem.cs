using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Purchase_Order;
using Common;

namespace BOL.Purchase_Order_Item
{
    public class PurchaseOrderItem : IPurchaseOrderItems
    {
        public int ItemID { get; set; }
        public int PurchaseOrderID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Reason { get; set; }
        public string Source { get; set; }
        public ItemStatus Status { get; set; }
        public string Justification { get; set; }

    }
}
