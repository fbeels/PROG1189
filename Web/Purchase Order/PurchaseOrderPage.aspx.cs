using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BOL.Purchase_Order;
using BOL.Purchase_Order_Item;
using Common;

namespace WebCSharp.PurchaseOrder
{
    public partial class PurchaseOrder : System.Web.UI.Page
    {

        BOL.Purchase_Order.PurchaseOrder myPurchaseOrder;
        bool isEdit = false;
        int PO_ID = 0;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["LoggedInID"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }


            setVisibilityOfID(false);
            setVisibilityOfMoneyLabels(false);

            lblDate.Text = DateTime.Now.ToShortDateString();

            if (!Page.IsPostBack)
            {
                SetInitialRow();

                myPurchaseOrder = PurchaseOrderFactory.Create();
                myPurchaseOrder.Items = new List<PurchaseOrderItem>();

            }


            if (Request.QueryString["id"] != null)
            {
                PO_ID = int.Parse(Request.QueryString["id"]);
                myPurchaseOrder = PurchaseOrderFactory.Create(PO_ID);
                isEdit = true;
                lblPage.Text = "Modify Purchase Order";

                if (!Page.IsPostBack)
                {
                    SetupModify();
                }

            }
            else {
                lblPage.Text = "Create Purchase Order";
                isEdit = false;
            }

            if ((ViewState["PO"] == null) && (ViewState["Items"] == null))
            {
                ViewState["PO"] = myPurchaseOrder;
            }
            else {
                myPurchaseOrder = (BOL.Purchase_Order.PurchaseOrder)ViewState["PO"];
            }

            loadEmp();
        }


        /// <summary>
        /// Loads all relevant data for modifying purchase orders
        /// </summary>
        public void SetupModify()
        {
            int rowIndex = 0;

            for (int i = 0; i <= myPurchaseOrder.Items.Count - 1; i++)
            {

                TextBox txtName = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("txtName");
                TextBox txtDesc = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("txtDesc");
                TextBox txtPrice = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("txtPrice");
                TextBox txtQ = (TextBox)Gridview1.Rows[rowIndex].Cells[4].FindControl("txtQ");
                TextBox txtStore = (TextBox)Gridview1.Rows[rowIndex].Cells[5].FindControl("txtStore");
                TextBox txtJust = (TextBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("txtJust");
                Label lblStatus = (Label)Gridview1.Rows[rowIndex].Cells[6].FindControl("lblStatus");
                Label lblReason = (Label)Gridview1.Rows[rowIndex].Cells[6].FindControl("lblReason");
                CheckBox chkNotNeeded = (CheckBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("chkNotNeeded");

                Button btn = (Button)Gridview1.FooterRow.Cells[6].FindControl("buttonAdd");


                txtName.Text = myPurchaseOrder.Items[i].ItemName;
                txtDesc.Text = myPurchaseOrder.Items[i].Description;
                txtPrice.Text = myPurchaseOrder.Items[i].Price.ToString();
                txtQ.Text = myPurchaseOrder.Items[i].Quantity.ToString();
                txtStore.Text = myPurchaseOrder.Items[i].Source;
                txtJust.Text = myPurchaseOrder.Items[i].Justification;
                lblStatus.Text = myPurchaseOrder.Items[i].Status.ToString();
                lblReason.Text = myPurchaseOrder.Items[i].Reason;
                if (txtDesc.Text == "No longer needed")
                {
                    chkNotNeeded.Checked = true;
                }


                if (myPurchaseOrder.Status == OrderStatus.Closed)
                {
                    txtDesc.Enabled = false;
                    txtName.Enabled = false;
                    txtPrice.Enabled = false;
                    txtQ.Enabled = false;
                    txtJust.Enabled = false;
                    txtStore.Enabled = false;
                    chkNotNeeded.Enabled = false;
                    btnSubmit.Enabled = false;

                    btn.Enabled = false;

                }

                rowIndex += 1;
                if (rowIndex == myPurchaseOrder.Items.Count && myPurchaseOrder.Status == OrderStatus.Closed)
                {
                    break;
                }
                AddNewRowToGrid(false, true);
            }

            setVisibilityOfID(true);
            setVisibilityOfMoneyLabels(true);
            doTaxCalculations();

            lblID.Text = myPurchaseOrder.PurchaseOrderID.ToString();
            lblPOStatus.Text = myPurchaseOrder.Status.ToString();
        }


        #region "Add PO/Items Controls"

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewRowToGrid(false, false);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (myPurchaseOrder.Status == OrderStatus.Closed)
            {
                Button btn = (Button)sender;
                btn.Enabled = false;

            }

            AddNewRowToGrid(true, false);

            lblError.ForeColor = System.Drawing.Color.Black;
            lblError.Text = "Order sent!";
        }

        /// <summary>
        /// Sets the inital rows in the gridview
        /// </summary>
        private void SetInitialRow()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("Column1", typeof(string)));
            dt.Columns.Add(new DataColumn("Column2", typeof(string)));
            dt.Columns.Add(new DataColumn("Column3", typeof(string)));
            dt.Columns.Add(new DataColumn("Column4", typeof(string)));
            dt.Columns.Add(new DataColumn("Column5", typeof(string)));
            dt.Columns.Add(new DataColumn("Column6", typeof(string)));
            dt.Columns.Add(new DataColumn("Column7", typeof(string)));
            dt.Columns.Add(new DataColumn("Column8", typeof(string)));
            dt.Columns.Add(new DataColumn("Column9", typeof(bool)));
            dr = dt.NewRow();
            dr["RowNumber"] = 1;
            dr["Column1"] = string.Empty;
            dr["Column2"] = string.Empty;
            dr["Column3"] = string.Empty;
            dr["Column4"] = string.Empty;
            dr["Column5"] = string.Empty;
            dr["Column6"] = string.Empty;
            dr["Column7"] = string.Empty;
            dr["Column9"] = false;
            dt.Rows.Add(dr);
            ViewState["CurrentTable"] = dt;
            Gridview1.DataSource = dt;
            Gridview1.DataBind();
        }



        /// <summary>
        /// Adds a new row the gridview, and does all insert logic
        /// </summary>
        private void AddNewRowToGrid(bool isSubmit, bool skipInsertLogic)
        {
            try
            {


                int rowIndex = 0;

                if (ViewState["CurrentTable"] != null)
                {
                    DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                    DataRow drCurrentRow = null;

                    if (dtCurrentTable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                        {
                            TextBox txtName = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("txtName");
                            TextBox txtDesc = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("txtDesc");
                            TextBox txtPrice = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("txtPrice");
                            TextBox txtQ = (TextBox)Gridview1.Rows[rowIndex].Cells[4].FindControl("txtQ");
                            TextBox txtStore = (TextBox)Gridview1.Rows[rowIndex].Cells[5].FindControl("txtStore");
                            TextBox txtJust = (TextBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("txtJust");
                            Label lblStatus = (Label)Gridview1.Rows[rowIndex].Cells[7].FindControl("lblStatus");
                            Label lblReason = (Label)Gridview1.Rows[rowIndex].Cells[6].FindControl("lblReason");
                            CheckBox chkNotNeeded = (CheckBox)Gridview1.Rows[rowIndex].Cells[8].FindControl("chkNotNeeded");

                            drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["RowNumber"] = i + 1;
                            // if its the last row and it's empty, exit looop
                            if (i == dtCurrentTable.Rows.Count & txtName.Text == string.Empty & txtDesc.Text == string.Empty & txtStore.Text == string.Empty & txtJust.Text == string.Empty)
                            {
                                break;
                            }

                            if (skipInsertLogic == false)
                            {
                                if (rowIndex != dtCurrentTable.Rows.Count)
                                {
                                    PurchaseOrderItem item = PurchaseOrderItemFactory.Create();

                                    if (chkNotNeeded.Checked)
                                    {
                                        PurchaseOrderItem.noLongerNeeded(item);

                                        txtPrice.Text = 0.ToString();
                                        txtQ.Text = 0.ToString();
                                        txtDesc.Text = "No longer needed";
                                    }

                                    try
                                    {
                                        item.ItemName = txtName.Text;
                                        item.Description = txtDesc.Text;

                                        //skip validation for these, since they are empty and will trigger validation
                                        if (txtDesc.Text != "No longer needed")
                                        {
                                            item.Price = double.Parse(txtPrice.Text);
                                            item.Quantity = int.Parse(txtQ.Text);
                                        }

                                        item.Source = txtStore.Text;
                                        item.Justification = txtJust.Text;
                                    }
                                    catch (Exception)
                                    {
                                        lblError.Text = "One or more fields are invalid. Please check.";
                                        return;
                                    }


                                    //if the rowindex is equal to the rowcount AKA the last row, give it a fake index so it can be found and replaced later
                                    if (rowIndex == dtCurrentTable.Rows.Count - 1)
                                    {
                                        item.ItemID = -1;
                                    }

                                    // if PO has an id of 0 AKA not inserted then do so
                                    if (myPurchaseOrder.PurchaseOrderID == 0)
                                    {
                                        myPurchaseOrder.Items.Insert(rowIndex, item);
                                        myPurchaseOrder.OrderDate = DateTime.Now;
                                        myPurchaseOrder.Status = OrderStatus.Pending;
                                        myPurchaseOrder.EmployeeID = int.Parse(Session["LoggedInID"].ToString());
                                        doTaxCalculations();

                                        Dictionary<string, int> ids = PurchaseOrderCUD.Create(myPurchaseOrder, item);
                                        //insert the PO and initial item, adding the ID's to a dict
                                        myPurchaseOrder.PurchaseOrderID = ids["POID"];
                                        myPurchaseOrder.Items[rowIndex].ItemID = ids["ItemID"];

                                        //if the po is already in the DB, update
                                    }
                                    else {

                                        bool merge = false;
                                        int mergeId = 0;
                                        for (int x = 0; x <= myPurchaseOrder.Items.Count - 1; x++)
                                        {
                                            if (item.ItemName == myPurchaseOrder.Items[x].ItemName & item.Description == myPurchaseOrder.Items[x].Description & rowIndex == dtCurrentTable.Rows.Count - 1)
                                            {
                                                merge = true;
                                                mergeId = x;
                                                break;
                                            }
                                            else {
                                                merge = false;
                                            }
                                        }

                                        if (merge)
                                        {
                                            //merge

                                            myPurchaseOrder.Items[mergeId].Quantity += item.Quantity;
                                            doTaxCalculations();
                                            PurchaseOrderItemCUD.Update(myPurchaseOrder.Items[mergeId]);
                                            PurchaseOrderCUD.Update(myPurchaseOrder);
                                            txtName.Text = string.Empty;
                                            txtDesc.Text = string.Empty;
                                            txtPrice.Text = string.Empty;
                                            txtQ.Text = string.Empty;
                                            txtStore.Text = string.Empty;
                                            txtJust.Text = string.Empty;
                                            lblStatus.Text = string.Empty;
                                            SetPreviousData();
                                            return;
                                        }
                                        else if (rowIndex == myPurchaseOrder.Items.Count)
                                        {
                                            //insert
                                            item.PurchaseOrderID = myPurchaseOrder.PurchaseOrderID;
                                            myPurchaseOrder.Items.Insert(rowIndex, item);
                                            doTaxCalculations();
                                            myPurchaseOrder.Items.Last().ItemID = PurchaseOrderItemCUD.Insert(item);
                                            PurchaseOrderCUD.Update(myPurchaseOrder);
                                        }
                                        else {
                                            //update
                                            item.ItemID = myPurchaseOrder.Items[rowIndex].ItemID;
                                            item.PurchaseOrderID = myPurchaseOrder.Items[rowIndex].PurchaseOrderID;

                                            if (item.Description == "No longer needed")
                                            {
                                                item.Status = ItemStatus.Denied;
                                            }

                                            myPurchaseOrder.Items.RemoveAt(rowIndex);
                                            myPurchaseOrder.Items.Insert(rowIndex, item);
                                            doTaxCalculations();
                                            PurchaseOrderItemCUD.Update(myPurchaseOrder.Items[rowIndex]);
                                            PurchaseOrderCUD.Update(myPurchaseOrder);
                                        }
                                    }
                                }
                            }
                            else {
                                if (rowIndex != dtCurrentTable.Rows.Count - 1)
                                {
                                    txtName.Text = myPurchaseOrder.Items[rowIndex].ItemName;
                                    txtDesc.Text = myPurchaseOrder.Items[rowIndex].Description;
                                    txtPrice.Text = myPurchaseOrder.Items[rowIndex].Price.ToString();
                                    txtQ.Text = myPurchaseOrder.Items[rowIndex].Quantity.ToString();
                                    txtStore.Text = myPurchaseOrder.Items[rowIndex].Source;
                                    txtJust.Text = myPurchaseOrder.Items[rowIndex].Justification;
                                    lblStatus.Text = myPurchaseOrder.Items[rowIndex].Status.ToString();
                                }
                            }
                            ViewState["PO"] = myPurchaseOrder;

                            if (rowIndex == dtCurrentTable.Rows.Count - 1 && txtName.Text != string.Empty)
                            {
                                lblStatus.Text = myPurchaseOrder.Items[rowIndex].Status.ToString();
                            }

                            dtCurrentTable.Rows[i - 1]["Column1"] = txtName.Text;
                            dtCurrentTable.Rows[i - 1]["Column2"] = txtDesc.Text;
                            dtCurrentTable.Rows[i - 1]["Column3"] = txtPrice.Text;
                            dtCurrentTable.Rows[i - 1]["Column4"] = txtQ.Text;
                            dtCurrentTable.Rows[i - 1]["Column5"] = txtStore.Text;
                            dtCurrentTable.Rows[i - 1]["Column6"] = txtJust.Text;
                            dtCurrentTable.Rows[i - 1]["Column7"] = lblStatus.Text;
                            dtCurrentTable.Rows[i - 1]["Column8"] = chkNotNeeded.Checked;

                            if (myPurchaseOrder.Status == OrderStatus.Closed)
                            {
                                txtDesc.Enabled = false;
                                txtName.Enabled = false;
                                txtPrice.Enabled = false;
                                txtQ.Enabled = false;
                                txtJust.Enabled = false;
                                txtStore.Enabled = false;
                                chkNotNeeded.Enabled = false;
                                btnSubmit.Enabled = false;

                            }
                            rowIndex += 1;
                        }

                        if (isSubmit == false)
                        {
                            dtCurrentTable.Rows.Add(drCurrentRow);
                            ViewState["CurrentTable"] = dtCurrentTable;
                            Gridview1.DataSource = dtCurrentTable;
                            Gridview1.DataBind();
                        }
                    }
                }
                else {
                    Response.Write("ViewState is null");
                }
                SetPreviousData();
                lblError.Text = "";
            }

            catch (Exception e)
            {

                lblError.Text = e.Message;
            }
        }

        /// <summary>
        /// Sets the previous data in the row
        /// </summary>
        private void SetPreviousData()
        {
            int rowIndex = 0;

            if (ViewState["CurrentTable"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count - 1; i++)
                    {
                        TextBox txtName = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("txtName");
                        TextBox txtDesc = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("txtDesc");
                        TextBox txtPrice = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("txtPrice");
                        TextBox txtQ = (TextBox)Gridview1.Rows[rowIndex].Cells[4].FindControl("txtQ");
                        TextBox txtStore = (TextBox)Gridview1.Rows[rowIndex].Cells[5].FindControl("txtStore");
                        TextBox txtJust = (TextBox)Gridview1.Rows[rowIndex].Cells[6].FindControl("txtJust");
                        Label lblStatus = (Label)Gridview1.Rows[rowIndex].Cells[7].FindControl("lblStatus");
                        Label lblReason = (Label)Gridview1.Rows[rowIndex].Cells[6].FindControl("lblReason");
                        CheckBox chkNotNeeded = (CheckBox)Gridview1.Rows[rowIndex].Cells[8].FindControl("chkNotNeeded");
                        txtName.Text = myPurchaseOrder.Items[i].ItemName;
                        txtDesc.Text = myPurchaseOrder.Items[i].Description;
                        txtPrice.Text = myPurchaseOrder.Items[i].Price.ToString();
                        txtQ.Text = myPurchaseOrder.Items[i].Quantity.ToString();
                        txtStore.Text = myPurchaseOrder.Items[i].Source;
                        txtJust.Text = myPurchaseOrder.Items[i].Justification;
                        lblReason.Text = myPurchaseOrder.Items[i].Reason;

                        if (myPurchaseOrder.Status == OrderStatus.UnderReview)
                        {
                            lblStatus.Text = "Under Review";
                            lblReason.Text = "Under Rewiew";
                        }
                        else
                        {
                            lblStatus.Text = myPurchaseOrder.Items[i].Status.ToString();
                        }


                        if (txtDesc.Text == "No longer needed")
                        {
                            chkNotNeeded.Checked = true;
                        }
                        else {
                            chkNotNeeded.Checked = false;
                        }

                        if (myPurchaseOrder.Status != OrderStatus.Pending)
                        {
                            txtDesc.Enabled = false;
                            txtName.Enabled = false;
                            txtPrice.Enabled = false;
                            txtQ.Enabled = false;
                            txtJust.Enabled = false;
                            txtStore.Enabled = false;
                            chkNotNeeded.Enabled = false;
                            if (myPurchaseOrder.Status == OrderStatus.Closed)
                            {
                                btnSubmit.Enabled = false;
                            }

                        }
                        rowIndex += 1;
                    }
                }
            }

            lblTotal.Text = myPurchaseOrder.calculateTotal().ToString("c2");
            lblTax.Text = myPurchaseOrder.calculateTax().ToString("c2");
            lblSubtotal.Text = myPurchaseOrder.calculateSubtotal().ToString("c2");
            lblID.Text = myPurchaseOrder.PurchaseOrderID.ToString();
            lblPOStatus.Text = myPurchaseOrder.Status.ToString();
            setVisibilityOfMoneyLabels(true);
            setVisibilityOfID(true);
        }
        #endregion


        #region "Misc Functions"
        /// <summary>
        /// Calculates the various caluclations in the myPurchaseOrder object.
        /// </summary>
        public void doTaxCalculations()
        {
            myPurchaseOrder.SubTotal = myPurchaseOrder.calculateSubtotal();
            myPurchaseOrder.Tax = myPurchaseOrder.calculateTax();
            myPurchaseOrder.Total = myPurchaseOrder.calculateTotal();

            lblSubtotal.Text = myPurchaseOrder.SubTotal.ToString("c2");
            lblTax.Text = myPurchaseOrder.Tax.ToString("c2");
            lblTotal.Text = myPurchaseOrder.Total.ToString("c2");
        }

        /// <summary>
        /// Sets the visibility of the labels that display the total, subtotal and tax amount
        /// </summary>
        /// <param name="value">The value of which to set the visibility to.</param>
        private void setVisibilityOfMoneyLabels(bool value)
        {
            panMoney.Visible = value;
        }
        /// <summary>
        /// Sets the visibility of the Order ID labels.
        /// </summary>
        /// <param name="value">Value of which the labels will be set to,</param>
        private void setVisibilityOfID(bool value)
        {
            orderID.Visible = value;
        }
        /// <summary>
        /// Loads the relevant labels with information about the employee, his department and his supervisor
        /// </summary>
        public void loadEmp()
        {
            Employee myEmp = Employee.retrieve(int.Parse(Session["LoggedInID"].ToString()));
            lblEmp.Text = myEmp.FirstName + " " + myEmp.LastName;

            Employee sup = Employee.retrieve(myEmp.SupervisorID);
            lblSuper.Text = sup.FirstName + " " + sup.LastName;
            Department dept = Department.GetADept(myEmp.DeptID);
            lblDept.Text = dept.DeptName;
        }
        #endregion     
    }
}