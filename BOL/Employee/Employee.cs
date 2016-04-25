using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using SQLLayer;


namespace BOL
{
    public class Employee
    {

        public string LastName { get; set; }
        public string MiddleInt { get; set; }
        public string FirstName { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Prov { get; set; }
        public string Postal { get; set; }
        public int EmpID { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string SIN { get; set; }
        public DateTime SeniorityDate { get; set; }
        public DateTime JobStartDate { get; set; }
        public int JobID { get; set; }
        public int DeptID { get; set; }
        public int SupervisorID { get; set; }
        public double PayRate { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool EmailNotification { get; set; }

        public Employee create(string Lastname, char MiddleIntm, string FirstName, DateTime DOB, string Address, string City, string Prov, string Postal, int EmpID, string Phone, string Cell, string Email, string SIN, DateTime SeniorityDate, DateTime JobStartDate, int JobID, int DeptID, int SupervisorID, double PayRate, bool EmailNotification, DateTime TerminationDate)
        {
            throw new System.NotImplementedException();
        }

        static public Employee create()
        {
            return new Employee();
        }

        static public List<Employee> search(int search_empid, string search_lname)
        {
               return SearchRePackager(EmployeeSQL.searchEmp(search_empid, search_lname));
        }


        static private List<Employee> SearchRePackager(DataTable dt)
        {
            List<Employee> myList = new List<Employee>();

            foreach (DataRow emps in dt.Rows)
            {
                Employee x = new Employee();
                x.EmpID = (int)emps[0];
                x.LastName = (string)emps[1];
                myList.Add(x);
            }
            return myList;
        }

        static public Employee retrieve(int empid)
        {
            return RePackager(EmployeeSQL.retrieveEmp(empid));
        }


        static private Employee RePackager(DataTable dt)
        {
            //Employee myList = new Employee();
            Employee x = new Employee();
            foreach (DataRow emps in dt.Rows)
            {
                
                x.EmpID = (int)emps[0];
                x.LastName = (string)emps[1];
                x.MiddleInt=(string)emps[2];
                x.FirstName=(string)emps[3];
                x.DOB=(DateTime)emps[4];
                x.Address=(string)emps[5];
                x.Prov=(string)emps[6];
                x.City = (string)emps[7];
                x.Postal = (string)emps[8];
                x.Phone = (string)emps[9];
                x.Cell = (string)emps[10];
                x.Email = (string)emps[11];
                x.SIN = (string)emps[12];
                x.SeniorityDate = (DateTime)emps[13];
                x.JobStartDate = (DateTime)emps[14];
                x.JobID = (int)emps[15];
                x.SupervisorID = (int)emps[16];
                x.EmailNotification = (bool)emps[17];
             //   x.PayRate = (double)emps[18];
                x.TerminationDate = (DateTime)emps[19];
                x.DeptID= (int)emps[20];


             //   myList.Add(x);
            }
            //return myList;
            return x;
        }
      
        //Public Overloads Shared Function create(Optional ByVal stusearchid As String = "", Optional ByVal stusearchfname As String = "",) As List(Of student)
        //    Dim dtstudents As DataTable = SQL.StudentSQL.RetrieveSome(stusearchid, stuseaerchlname)
        //    Return Repackage_IDNAME_Table_To_List(dtstudents)
        //End Function



        //Private Shared Function Repackage_IDNAME_Table_To_List(dtemp As DataTable) As List(Of student)

        //    Dim listofstudents As New List(Of student)
        //    Dim stu As student = Nothing

        //    'Iterate through each of the rows in the DataTable
        //    For Each dr As DataRow In dtemp.Rows
        //        'Instantiate the JobAssignmentReport intance for the current iteration
        //        stu = New student
        //        'strDetail = row.Item("Detail")

        //        stu._studentid = CStr(dr.Item(0)) '            studentid nchar(8)
        //        stu._firstname = CStr(dr.Item(1)) + " " + CStr(dr.Item(2)) ' 
        //        '   stu._firstname = CStr(dr.Item(1))        '   firstname varchar(50)
        //        '  stu._lastname = CStr(dr.Item(2)) '            lastname varchar(50)

        //        'Add the inidividual object to the list
        //        listofstudents.Add(stu)
        //    Next

        //    Return listofstudents

        //End Function



}//end of class
}//end of namespace
