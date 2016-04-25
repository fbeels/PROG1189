using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOL
{
    public class Employee
    {

        public string LastName { get; set; }
        public char MiddleInt { get; set; }
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
        public string JobAssignment { get; set; }
        public string Dept { get; set; }
        public int SupervisorID { get; set; }
        public double PayRate { get; set; }
        public bool EmailNotification { get; set; }

        public Employee create(string Lastname, char MiddleIntm, string FirstName, DateTime DOB, string Address, string City, string Prov, string Postal, int EmpID, string Phone, string Cell, string Email, string SIN,DateTime SeniorityDate,DateTime JobStartDate,string JobAssignment,string Dept,int SupervisorID,double PayRate,bool EmailNotification)
        {
            throw new System.NotImplementedException();
        }

        static public Employee create()
        {
            return new Employee();
        }








}//end of class
}//end of namespace
