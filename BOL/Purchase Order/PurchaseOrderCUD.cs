using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLLayer;
namespace BOL.Purchase_Order
{
    static public class PurchaseOrderCUD
    {
        static public int Create(PurchaseOrder PO, Purchase_Order_Item.PurchaseOrderItem item) 
        {
            return PurchaseOrderSQL.createInitialPO(item, PO);
        }

        static public bool Update(PurchaseOrder PO)
        {
            return PurchaseOrderSQL.modifyPO(PO);
        }





    }
}
