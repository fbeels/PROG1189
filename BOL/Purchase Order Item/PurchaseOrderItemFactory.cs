using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTypes;
using SQLLayer;

namespace BOL.Purchase_Order_Item
{
    static class PurchaseOrderItemFactory
    {

        static public PurchaseOrderItem Create()
        {
            return new PurchaseOrderItem();
        }

        static public PurchaseOrderItem Create(int ItemID)
        {
            DataTable x = PurchaseOrderItemSQL.retrievePurchaseOrderItem(ItemID);

            return RePackager(x);
        }

        static private PurchaseOrderItem RePackager(DataTable dt)
        {
            PurchaseOrderItem x = new PurchaseOrderItem();

            foreach (DataRow row in dt.Rows)
            {
                x.ItemID = int.Parse(row["po_item_ID"].ToString());
                x.Description = row["desc"].ToString();
                x.ItemName = row["itemname"].ToString();
                //x.PurchaseOrder = row["itemname"].ToString();
                x.Price = double.Parse(row["price"].ToString());
                x.Quantity = int.Parse(row["quantity"].ToString());
                x.Reason = row["reason"].ToString();
                x.Source = row["source"].ToString();
                x.Status = (ItemStatus) int.Parse(row["reason"].ToString());
                x.Justification = row["justification"].ToString();
            }
            
            return x;
        }

    }
}
