using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Payroll
{
    public partial class Modify : System.Web.UI.Page
    {
        Employee myEmp = new Employee();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

            myEmp = Employee.retrieve(int.Parse(ddlEmployees.Text));
            txtempid.Text = (myEmp.EmpID).ToString();
            txtempid.Enabled = false;
            txtFirst.Text = myEmp.FirstName;
            txtFirst.Enabled = false;
            txtMid.Text = myEmp.MiddleInt;
            txtMid.Enabled = false;
            txtLast.Text =myEmp.LastName;
            txtLast.Enabled = false;
            txtStreet.Text = myEmp.Address;
            txtCity.Text = myEmp.City;
            ddlProv.ClearSelection();
            ddlProv.SelectedValue = myEmp.Prov;
            txtCell.Text = myEmp.Cell;
            txtPostal.Text = myEmp.Postal;
            txtwork.Text = myEmp.Phone;
            txtemail.Text = myEmp.Email;


            txtdob.Text = (myEmp.DOB).ToShortDateString();
            txtsin.Text = myEmp.SIN;
            txtseniorityDate.Text = (myEmp.SeniorityDate).ToShortDateString();
            txtjobstartDate.Text = (myEmp.JobStartDate).ToShortDateString();
            txtjobId.Text = (myEmp.JobID).ToString();
            txtsupervisiorID.Text = (myEmp.SupervisorID).ToString();
              txtemailnotificatoins.Text = (myEmp.EmailNotification).ToString();
             txtpayrate.Text = (myEmp.PayRate).ToString();
            txtterminationDate.Text = (myEmp.TerminationDate).ToShortDateString();
             txtdeptID.Text = (myEmp.JobID).ToString();
             txtempstatus.Text = (myEmp.JobID).ToString();
            txtlastchanged.Text = (myEmp.JobID).ToString();



        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //try
            //{

            Employee emp2save = Employee.create();
            emp2save.EmpID = int.Parse(txtempid.Text);
            emp2save.FirstName = txtFirst.Text;
            emp2save.MiddleInt = txtMid.Text;
            emp2save.LastName = txtLast.Text;
            emp2save.Address = txtStreet.Text;
            emp2save.City = txtCity.Text;
            emp2save.Prov = ddlProv.SelectedValue;
            emp2save.Cell = txtCell.Text;
            emp2save.Postal = txtPostal.Text;
            emp2save.Phone = txtwork.Text;
            emp2save.Email = txtemail.Text;
            emp2save.JobStartDate = DateTime.Parse(txtjobstartDate.Text);
            emp2save.SeniorityDate = DateTime.Parse(txtseniorityDate.Text);
            emp2save.DOB = DateTime.Parse(txtdob.Text);
            emp2save.TerminationDate = DateTime.Parse(txtterminationDate.Text);

            emp2save.DeptID = myEmp.DeptID;
            //emp2save.DOB = myEmp.DOB;
            emp2save.EmailNotification = myEmp.EmailNotification;
            emp2save.empstatus = myEmp.empstatus;
            emp2save.JobID = myEmp.JobID;
            //emp2save.JobStartDate = myEmp.JobStartDate;
            emp2save.PayRate = myEmp.PayRate;
            //emp2save.SeniorityDate = myEmp.SeniorityDate;
            emp2save.CANRETIRE = myEmp.CANRETIRE;
            emp2save.SupervisorID = myEmp.SupervisorID;
            emp2save.supervisorName = myEmp.supervisorName;
           // emp2save.TerminationDate = myEmp.TerminationDate;
            emp2save.SIN = myEmp.SIN;

            if (Employee.update(emp2save) == true)
            {
                lblresult.Text = "Saved";
            }
            else
            {
                lblresult.Text = "error";
            }
            //}
            //catch
            //{

            //}
        }
    }//end of public partial class Modify
}//end of namespace Web.Payroll