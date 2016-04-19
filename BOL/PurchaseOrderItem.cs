using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTypes;

namespace BOL
{
    public class PurchaseOrderItem
    {
        public int ItemID { get; set; }
        public PurchaseOrder PO { get; set; }

        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Reason { get; set; }
        public string Source { get; set; }
        public ItemStatus Status { get; set; }




    }
}
