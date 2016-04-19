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

        public Employee create()
        {
            throw new System.NotImplementedException();
        }

        public Employee update()
        {
            throw new System.NotImplementedException();
        }
        
    }
}
