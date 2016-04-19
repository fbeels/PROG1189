using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOL
{
    public class EmploymentInfo
    {

        public Employee EmpID { get; set; }
        public string SIN { get; set; }
        public DateTime SeniorityDate { get; set; }
        public DateTime JobStartDate { get; set; }
        public string JobAssignment { get; set; }
        public string Dept { get; set; }
        public Employee SupervisorID { get; set; }
        public double PayRate { get; set; }
        public bool EmailNotification { get; set; }

    }
}
