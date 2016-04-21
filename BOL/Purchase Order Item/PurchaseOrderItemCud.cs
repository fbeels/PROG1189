using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Purchase_Order_Item
{
    class PurchaseOrderItemCUD
    {
        public static int Insert(PurchaseOrderItem item)
        {
            return SQLLayer.PurchaseOrderItemSQL.insertPurchaseOrderItem(item);
        }

        public static bool Update(PurchaseOrderItem Item)
        {
            return SQLLayer.PurchaseOrderItemSQL.modifyItem(Item);
        }

    }
}
