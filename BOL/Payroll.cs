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
    public class Payroll
    {

        public int ChequeID { get; set; }
        public Employee EmpID { get; set; }
        public double Payrate { get; set; }
        public double IncomeTax { get; set; }
        public double CPP { get; set; }
        public double EI { get; set; }
        public double Pension { get; set; }

       


        static public Boolean RunPayRoll(String strpasscode)
        {
            return RePackagerdt2bool(PayRollSQL.RunPayRoll(strpasscode));
        }
        static private Boolean RePackagerdt2bool(DataTable dt)
        {
            ////Employee myList = new Employee();
            //Employee x = new Employee();
            //int y = 0;
            //foreach (DataRow emps in dt.Rows)
            //{
            //    //  x.EmpID = (int)emps[0];
            //    y = (int)emps[0];
            //}
            ////return myList;
            //return y;
            return true;
        }



    }
}
