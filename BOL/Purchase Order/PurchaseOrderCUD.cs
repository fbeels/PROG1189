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
        /// <summary>
        /// Executes creating a new PO
        /// </summary>
        /// <param name="PO">PO to create</param>
        /// <param name="item">Item to add</param>
        /// <returns>Returns a dict holding the ID of the PO and the item.</returns>
        static public Dictionary<string,int> Create(PurchaseOrder PO, Purchase_Order_Item.PurchaseOrderItem item) 
        {
            return PurchaseOrderSQL.createInitialPO(item, PO);
        }

        /// <summary>
        /// Executes an update
        /// </summary>
        /// <param name="PO"> PO that is updated</param>
        /// <returns></returns>
        static public bool Update(PurchaseOrder PO)
        {           
            if(PurchaseOrderSQL.modifyPO(PO))
            {
                PO.lastupdated++;
                return true;
            }
            return false;
        }





    }
}
