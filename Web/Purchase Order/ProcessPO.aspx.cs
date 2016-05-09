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
        PurchaseOrderItem myItem;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                pnlItemInfo.Visible = false;
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

                lblReason.Visible = false;
                txtReason.Visible = false;



                if (!Page.IsPostBack)
                {
                    if (myPurchaseOrder.Status != OrderStatus.Closed)
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


                if (Request.QueryString["iid"] != null)
                {
                    myItem = PurchaseOrderItemFactory.Create(int.Parse(Request.QueryString["iid"]));

                    pnlItemInfo.Visible = true;

                    if (!Page.IsPostBack)
                    {
                        txtID.Text = myItem.ItemID.ToString();
                        txtName.Text = myItem.ItemName;
                        txtDesc.Text = myItem.Description;
                        txtPrice.Text = myItem.Price.ToString();
                        txtQuantity.Text = myItem.Quantity.ToString();
                        txtJustification.Text = myItem.Justification;
                        txtSource.Text = myItem.Source;
                        ddlStatus.SelectedIndex = (int)myItem.Status;
                        txtReason.Text = myItem.Reason;
                    }
                }
            }
            else {
                Response.Redirect("SearchPOSupervisor.aspx");
            }



            if (myPurchaseOrder.Status == OrderStatus.Closed)
            {
                txtID.Enabled = false;
                txtName.Enabled = false;
                txtDesc.Enabled = false;
                txtPrice.Enabled = false;
                txtQuantity.Enabled = false;
                txtSource.Enabled = false;
                txtJustification.Enabled = false;
                txtReason.Enabled = false;
                btnSubmit.Enabled = false;
                ddlStatus.Enabled = false;


                lblReason.Visible = true;
                txtReason.Visible = true;

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
                Row["ID"] = "<a href='ProcessPO.aspx?id=" + Request.QueryString["id"].ToString() + "&iid=" + id + "' >" + id + "</a>";
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
            Response.Redirect("ProcessPO.aspx?id=" + myPurchaseOrder.PurchaseOrderID.ToString());
        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStatus.SelectedIndex != 0)
            {
                lblReason.Visible = true;
                txtReason.Visible = true;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.Equals(myItem.ItemName, txtName.Text) == true || string.Equals(myItem.Description, txtDesc.Text) == true || string.Equals(myItem.Price.ToString(), txtPrice.Text) == true || string.Equals(myItem.Quantity.ToString(), txtQuantity.Text) == true || string.Equals(myItem.Source, txtSource.Text) == true || string.Equals(myItem.Justification, txtJustification.Text) == true)
            {

                if (txtReason.Text == string.Empty)
                {
                    lblMsg.Text = "Must provide a reason to change the item.";
                }
                else
                {
                    myItem.ItemName = Validation.String(txtName.Text);
                    myItem.Description = Validation.String(txtDesc.Text);
                    myItem.Price = Validation.Double(txtPrice.Text);
                    myItem.Quantity = int.Parse(Validation.String(txtQuantity.Text));
                    myItem.Source = Validation.String(txtSource.Text);
                    myItem.Justification = Validation.String(txtJustification.Text);
                    myItem.Reason = Validation.String(txtReason.Text);
                }

            }


            if (ddlStatus.SelectedIndex == 1)
            {
                PurchaseOrderItem.approveItem(myItem);
                BOL.Purchase_Order.PurchaseOrder.markUnderReview(myPurchaseOrder);
                Response.Redirect(Request.RawUrl);
            }
            else if (ddlStatus.SelectedIndex == 1)
            {
                if (txtReason.Text != string.Empty)
                {
                    PurchaseOrderItem.denyItem(myItem, txtReason.Text);
                    BOL.Purchase_Order.PurchaseOrder.markUnderReview(myPurchaseOrder);
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    lblMsg.Text = "Must supply a reason to deny item!";
                }
            }

        }
    }
}