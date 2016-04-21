using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLLayer;
namespace BOL.Purchase_Order
{
    class PurchaseOrderCUD
    {
        public bool Create(PurchaseOrder PO, Purchase_Order_Item.PurchaseOrderItem item) 
        {
            return PurchaseOrderSQL.createInitialPO(item, PO);
        }

        public bool Update(PurchaseOrder PO)
        {
            return PurchaseOrderSQL.modifyPO(PO);
        }


    }
}
