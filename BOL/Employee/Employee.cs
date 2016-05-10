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
        string _LastName;
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            { 
                if (value=="")
                {
                     throw new System.ArgumentException("from class: Lastname cannot be empty");
                }
                else
                {
                    this._LastName = value;
                }
                
            }
            
        }

        
       // public string LastName { get; set; }
        public string MiddleInt { get; set; }


        String _FirstName;
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: FirstName cannot be empty");
                }
                else
                {
                    this._FirstName = value;
                }

            }

        }

        //public string FirstName { get; set; }
        public DateTime DOB { get; set; }
       // public string Address { get; set; }

        String _Address;
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: Address cannot be empty");
                }
                else
                {
                    this._Address = value;
                }

            }

        }

        //public string City { get; set; }

        String _City;
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: City cannot be empty");
                }
                else
                {
                    this._City = value;
                }

            }
        }

       // public string Prov { get; set; }

        String _Prov;
        public string Prov
        {
            get
            {
                return this._Prov;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: Prov cannot be empty");
                }
                else
                {
                    this._Prov = value;
                }

            }
        }
      //  public string Postal { get; set; }

        String _Postal;
        public string Postal
        {
            get
            {
                return this._Postal;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: Postal cannot be empty");
                }
                else
                {
                    this._Postal = value;
                }

            }
        }


        public int EmpID { get; set; }
       // public string Phone { get; set; }

        String _Phone;
        public string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: workPhone cannot be empty");
                }
                else if (value.Length != 10)
                {
                    throw new System.ArgumentException("from class: workphone length must be 10 characters");
                }
                else
                {
                    this._Phone = value;
                }

            }
        }

       // public string Cell { get; set; }

        String _Cell;
        public string Cell
        {
            get
            {
                return this._Cell;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: Cell cannot be empty");
                }
                else if(value.Length!=10)
                {
                     throw new System.ArgumentException("from class: Cell length must be 10 characters");
                }
                else
                {
                    this._Cell = value;
                }
            }
        }
        
        //public string Email { get; set; }
        String _Email;
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: Email cannot be empty");
                }
                else
                {
                    this._Email = value;
                }

            }
        }
        
        
       // public string SIN { get; set; }
        String _SIN;
        public string SIN
        {
            get
            {
                return this._SIN;
            }
            set
            {
                if (value == "")
                {
                    throw new System.ArgumentException("from class: SIN cannot be empty");
                }
                else
                {
                    this._SIN = value;
                }

            }
        }

        
        //public DateTime SeniorityDate { get; set; }
        DateTime _SeniorityDate;
        public DateTime SeniorityDate
        {
            get
            {
                return this._SeniorityDate;
            }
            set
            {
                string startdate = "01/01/1500";
                DateTime dtstart = Convert.ToDateTime(startdate);
                if (value >= dtstart && value < Convert.ToDateTime("12/31/2222"))
                {         
                    this._SeniorityDate = value;
                }
                else
                {
                    throw new System.ArgumentException("from class: seniority date outside range");
                }

            }
        }

       // public DateTime JobStartDate { get; set; }
        DateTime _JobStartDate;
        public DateTime JobStartDate
        {
            get
            {
                return this._JobStartDate;
            }
            set
            {
                string startdate = "01/01/1500";
                DateTime dtstart = Convert.ToDateTime(startdate);
                if (value >= dtstart && value < Convert.ToDateTime("12/31/2222"))
                {
                    this._JobStartDate = value;
                }
                else
                {
                    throw new System.ArgumentException("from class: start date outside range");
                }

            }
        }
        
        public int JobID { get; set; }
        public int DeptID { get; set; }
        public int SupervisorID { get; set; }
        public string supervisorName { get; set;}
        public double PayRate { get; set; }
        
        
       // public DateTime TerminationDate { get; set; }
        DateTime _TerminationDate;
        public DateTime  TerminationDate
        {
            get
            {
                return this._TerminationDate;
            }
            set
            {
                if (value >= Convert.ToDateTime("01/01/1500") && value <= Convert.ToDateTime("12/31/2222"))
                {
                    this._TerminationDate = value;
                }
                else
                {
                    throw new System.ArgumentException("from class: termination date outside range");
                }

            }
        }

        public bool EmailNotification { get; set; }
        public int empstatus { get; set; }

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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="empid"></param>
        /// <returns></returns>
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
               // (x.empstatus)int.Parse(emps[21].ToString());
                // (int)emps[21];
               x.empstatus = int.Parse(emps[21].ToString());
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

        static public bool update(Employee emp)
        
        {
            return RePackagerDt2Bool(EmployeeSQL.UpdateEmp(emp));
        }

        static private bool RePackagerDt2Bool(DataTable dt)
        {
            //Employee myList = new Employee();
           // Employee x = new Employee();
            bool y = false;
            foreach (DataRow emps in dt.Rows)
            {
                //  x.EmpID = (int)emps[0];
                y = (bool)emps[0];
            }
            //return myList;
            return y;
        }



}//end of class
}//end of namespace
