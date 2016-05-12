using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using BOL.Purchase_Order;
using Common;
namespace WebCSharp.PurchaseOrder
{
    public partial class SearchPOSupervisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEndDate.Text = DateTime.Now.ToShortDateString();

            if (Session["LoggedInID"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<PurchaseOrderList> results;
            if (txtSearchDate.Text == string.Empty & txtEndDate.Text == string.Empty)
            {
                results = PurchaseOrderList.Create(int.Parse(Session["LoggedInID"].ToString()), ddlStatus.SelectedIndex, txtFirst.Text, txtLast.Text);
            }
            else
            {
                results = PurchaseOrderList.Create(int.Parse(Session["LoggedInID"].ToString()), ddlStatus.SelectedIndex, txtFirst.Text, txtLast.Text, DateTime.Parse(txtSearchDate.Text), DateTime.Parse(txtEndDate.Text));
            }

            if (results.Count == 0)
            {
                lblErr.Text = "No results";
            }
            else {
                lblErr.Text = "";
                loadDataGrid(results);
            }
        }

        public void loadDataGrid(List<PurchaseOrderList> results)
        {
            DataTable Table = new DataTable();

            var _with1 = Table.Columns;
            _with1.Add("ID", typeof(string));
            _with1.Add("Employee ID", typeof(int));
            _with1.Add("Status", typeof(string));
            _with1.Add("Total", typeof(string));
            _with1.Add("Order Date", typeof(string));

            for (int i = 0; i <= results.Count - 1; i++)
            {
                DataRow Row = default(DataRow);
                Row = Table.NewRow();
                int id = results[i].PurchaseOrderID;
                Row["ID"] = "<a href='ProcessPO.aspx?id=" + id + "' >" + id + "</a>";
                Row["Employee ID"] = results[i].EmployeeID;
                Row["Status"] = results[i].Status.ToString();
                Row["Total"] = results[i].Total.ToString("c2");
                Row["Order Date"] = results[i].OrderDate.ToShortDateString();
                Table.Rows.Add(Row);
            }
            dgData.DataSource = Table;
            dgData.DataBind();
        }
    }
}