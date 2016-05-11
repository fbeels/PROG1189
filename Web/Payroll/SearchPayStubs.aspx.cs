using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Payroll
{
    public partial class SearchPayStubs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             Session["empID"] = 10000001;
            Session["startDate"] = "1900-09-09";
            Session["endDate"] =  "2017-09-09";

        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }
    }
}