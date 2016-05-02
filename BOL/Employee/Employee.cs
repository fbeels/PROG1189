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
    public class Employee : IEmployee
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
        public string supervisorName { get; set;}
        public double PayRate { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool EmailNotification { get; set; }
        public int status { get; set; }

        //public Employee create(string Lastname, char MiddleIntm, string FirstName, DateTime DOB, string Address, string City, string Prov, string Postal, int EmpID, string Phone, string Cell, string Email, string SIN, DateTime SeniorityDate, DateTime JobStartDate, int JobID, int DeptID, int SupervisorID, double PayRate, bool EmailNotification, DateTime TerminationDate)
        //{
        //    throw new System.NotImplementedException();
        //}

        static public Employee create()
        {
            return new Employee();
        }
//-------------------------------------------------------------
      //retireve employee form
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
//-----------------------------------------------------------------------------------
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
               x.PayRate = System.Convert.ToDouble((Decimal)emps[18]);
                x.TerminationDate = (DateTime)emps[19];
                x.DeptID= (int)emps[20];
                x.status = int.Parse(emps[21].ToString());

                //   myList.Add(x);
            }
            //return myList;
            return x;
        }
      //-------------------------------------------------------------------

        static public List<Employee> GetAllEmpsInDept(int deptID)
        {
            return GetAllEmpsInDeptRePackager(EmployeeSQL.GetAllEmpsInDept(deptID));
        }


        static private List<Employee> GetAllEmpsInDeptRePackager(DataTable dt)
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

        static public int insert(Employee emp)
        {
            return RePackagerdt2int(EmployeeSQL.insertEmp(emp));
        }

        static private int RePackagerdt2int(DataTable dt)
        {
            //Employee myList = new Employee();
            Employee x = new Employee();
            int y=0;
            foreach (DataRow emps in dt.Rows)
            {
                //  x.EmpID = (int)emps[0];
                y = (int)emps[0];
            }
            //return myList;
            return y;
        }



}//end of class
}//end of namespace
