using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using SQLLayer;

namespace BOL.Purchase_Order_Item
{
    public static class PurchaseOrderItemFactory
    {

        static public PurchaseOrderItem Create()
        {
            return new PurchaseOrderItem();
        }

        static public PurchaseOrderItem Create(int ItemID)
        {
            DataTable dt = PurchaseOrderItemSQL.retrievePurchaseOrderItem(ItemID);

            return RePackager(dt);
        }

        static private PurchaseOrderItem RePackager(DataTable dt)
        {
            PurchaseOrderItem item = new PurchaseOrderItem();

            foreach (DataRow row in dt.Rows)
            {
                item.ItemID = int.Parse(row["po_item_ID"].ToString());
                item.Description = row["itemdesc"].ToString();
                item.ItemName = row["itemname"].ToString();
                item.PurchaseOrderID = int.Parse(row["po_id"].ToString());
                item.Price = double.Parse(row["price"].ToString());
                item.Quantity = int.Parse(row["quantity"].ToString());
                item.Reason = row["reason"].ToString();
                item.Source = row["source"].ToString();
                item.Status = (ItemStatus)int.Parse(row["itemstatus"].ToString());
                item.Justification = row["justification"].ToString();
                item.lastudpated = int.Parse(row["lastupdated"].ToString());

            }

            return item;
        }

    }
}
