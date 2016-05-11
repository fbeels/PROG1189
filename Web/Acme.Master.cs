using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
namespace WebCSharp
{
    public partial class Acme : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();

            if (Session["LoggedInID"] != null)
            {
                Employee myEmp = Employee.retrieve(int.Parse(Session["LoggedInID"].ToString()));
                LoggedIn.Visible = true;
                lblLoggedIn.Text = myEmp.FirstName + " " + myEmp.LastName + " | " + myEmp.EmpID;
                
            }
            else
            {
                LoggedIn.Visible = false;
            }
        }
    }
}