using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOL
{
    public class Payroll
    {

        public int ChequeID { get; set; }
        public Employee EmpID { get; set; }
        public double Payrate { get; set; }
        public double IncomeTax { get; set; }
        public double CPP { get; set; }
        public double EI { get; set; }
        public double Pension { get; set; }

        public Payroll create()
        {
            throw new System.NotImplementedException();
        }

        public Payroll update()
        {
            throw new System.NotImplementedException();
        }

    }
}
