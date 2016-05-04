using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using BOL.Purchase_Order;
using BOL.Purchase_Order_Item;
using BOL;
using Common;
using System.Data;

namespace WebCSharp.PurchaseOrder
{
    public partial class ProcessPO : System.Web.UI.Page
    {
        BOL.Purchase_Order.PurchaseOrder myPurchaseOrder;

        Employee myEmployee;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                myPurchaseOrder = PurchaseOrderFactory.Create(int.Parse(Request.QueryString["id"]));
                myEmployee = Employee.retrieve(myPurchaseOrder.EmployeeID);

                loadData();

                lblEmp.Text = myEmployee.FirstName + " " + myEmployee.LastName;
                lblPoDate.Text = myPurchaseOrder.OrderDate.ToShortDateString();
                lblPoNum.Text = myPurchaseOrder.PurchaseOrderID.ToString();
                lblSubtotal.Text = myPurchaseOrder.calculateSubtotal().ToString("C2");
                lblTax.Text = myPurchaseOrder.calculateTax().ToString("C2");
                lblTotal.Text = myPurchaseOrder.calculateTotal().ToString("C2");
                lblPoStatus.Text = myPurchaseOrder.Status.ToString();

                btnNo.Visible = false;
                btnYes.Visible = false;
                lblClose.Visible = false;

                if (!Page.IsPostBack)
                {
                    if (myPurchaseOrder.Items.Exists(myItem => myItem.Status == ItemStatus.Denied || myItem.Status == ItemStatus.Approved))
                    {
                        btnNo.Visible = true;
                        btnYes.Visible = true;
                        lblClose.Visible = true;
                    }
                    else if (myPurchaseOrder.Items.Exists(myItem => myItem.Status == ItemStatus.Pending))
                    {
                       BOL.Purchase_Order.PurchaseOrder.markPending(myPurchaseOrder);
                    }
                }
            }
            else {
                Response.Redirect("SearchPOSupervisor.aspx");
            }
        }


        private void loadData()
        {
            DataTable Table = new DataTable();
            var _with1 = Table.Columns;
            _with1.Add("ID", typeof(string));
            _with1.Add("Name", typeof(string));
            _with1.Add("Description", typeof(string));
            _with1.Add("Price", typeof(string));
            _with1.Add("Quantity", typeof(string));
            _with1.Add("Source", typeof(string));
            _with1.Add("Justification", typeof(string));
            _with1.Add("Status", typeof(string));
            _with1.Add("Reason", typeof(string));

            for (int i = 0; i <= myPurchaseOrder.Items.Count - 1; i++)
            {
                DataRow Row = default(DataRow);
                Row = Table.NewRow();
                int id = myPurchaseOrder.Items[i].ItemID;
                Row["ID"] = "<a href='EditItemStatus.aspx?id=" + id + "' >" + id + "</a>";
                Row["Name"] = myPurchaseOrder.Items[i].ItemName;
                Row["Description"] = myPurchaseOrder.Items[i].Description;
                Row["Price"] = myPurchaseOrder.Items[i].Price;
                Row["Quantity"] = myPurchaseOrder.Items[i].Quantity;
                Row["Source"] = myPurchaseOrder.Items[i].Source;
                Row["Justification"] = myPurchaseOrder.Items[i].Justification;
                Row["Status"] = myPurchaseOrder.Items[i].Status.ToString();
                Row["Reason"] = myPurchaseOrder.Items[i].Reason;
                Table.Rows.Add(Row);
            }

            dgData.DataSource = Table;
            dgData.DataBind();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            BOL.Purchase_Order.PurchaseOrder.closeOrder(myPurchaseOrder);
        }
    }
}