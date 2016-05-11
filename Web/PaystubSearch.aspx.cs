using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class PaystubSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {          
            //Session["empID"] = 10000001;
            //Session["startDate"] = "1900-09-09";
            //Session["endDate"] = "2017-09-09";
            if (Page.IsPostBack)
            {
                ReportViewer1.Visible = true;
                Session["empID"] = ddlEmployee.SelectedValue;
                Session["startDate"] = dtpStart.Text;
                Session["endDate"] = dtpEnd.Text;
            }
            else
            {
                ReportViewer1.Visible = false;
            }
        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            if (dtpEnd.Text != string.Empty || dtpStart.Text != string.Empty)
            {
                Session["empID"] = ddlEmployee.SelectedValue;
                Session["startDate"] = dtpStart.Text;
                Session["endDate"] = dtpEnd.Text;
            }
        }

    }
}