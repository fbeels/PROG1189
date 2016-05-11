using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using SQLLayer;
using BOL.Purchase_Order_Item;

namespace BOL.Purchase_Order
{
    static public class PurchaseOrderFactory
    {

        static public PurchaseOrder Create()
        {
            return new PurchaseOrder();
        }


        static public PurchaseOrder Create(int PO_ID)
        {
            DataTable podt = PurchaseOrderSQL.retrievePurchaseOrder(PO_ID);
            DataTable idt = PurchaseOrderItemSQL.retrievePurchaseOrderItemByOrderID(PO_ID);
            return RePackager(podt, idt);
        }

        static private PurchaseOrder RePackager(DataTable podt, DataTable idt)
        {
            PurchaseOrder po = new PurchaseOrder();
            po.Items = new List<PurchaseOrderItem>();

            foreach (DataRow row in podt.Rows)
            {
                po.PurchaseOrderID = int.Parse(row["poid"].ToString());
                po.OrderDate = DateTime.Parse(row["orderdate"].ToString());
                po.Tax = double.Parse(row["Tax"].ToString());
                po.SubTotal = double.Parse(row["subtotal"].ToString());
                po.Status = (OrderStatus)int.Parse(row["status"].ToString());
                po.EmployeeID = int.Parse(row["empid"].ToString());
                po.lastupdated = int.Parse(row["lastupdated"].ToString());

            }

            foreach (DataRow row in idt.Rows)
            {
                PurchaseOrderItem item = new PurchaseOrderItem();

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
                item.lastupdated = int.Parse(row["lastupdated"].ToString());

                po.Items.Add(item);
            }

            po.calculateSubtotal();
            po.calculateTax();
            po.Total = po.calculateTotal();
            return po;
        }
    }
}
