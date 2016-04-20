using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IPurchaseOrderItems
    {
        int ItemID { get; set; }
        int PurchaseOrderID { get; set; }
        string ItemName { get; set; }
        string Description { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }
        string Reason { get; set; }
        string Source { get; set; }
        ItemStatus Status { get; set; }
        string Justification { get; set; }
    }
}
