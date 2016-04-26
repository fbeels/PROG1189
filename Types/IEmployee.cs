using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IEmployee
    {
         string LastName { get; set; }
         string MiddleInt { get; set; }
         string FirstName { get; set; }
         DateTime DOB { get; set; }
         string Address { get; set; }
         string City { get; set; }
         string Prov { get; set; }
         string Postal { get; set; }
         int EmpID { get; set; }
         string Phone { get; set; }
         string Cell { get; set; }
         string Email { get; set; }
         string SIN { get; set; }
         DateTime SeniorityDate { get; set; }
         DateTime JobStartDate { get; set; }
         int JobID { get; set; }
        int DeptID { get; set; }
        int SupervisorID { get; set; }
        double PayRate { get; set; }
        DateTime TerminationDate { get; set; }
       bool EmailNotification { get; set; }
    }
}
