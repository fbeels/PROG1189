
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
    public class PayPeriod
    {

        public int Payrollid { get; set; }
        public DateTime Startdate { get; set; }

        public DateTime Enddate { get; set; }
        public Boolean hasbeenprocesed { get; set; }
   


     //retireve employee form
        static public int IsItPayday()
        {
            return IsItPaydayRePackager(PayPeriodSQL.IsItPayday());
        }

        static private int IsItPaydayRePackager(DataTable dt)
        {
            //List<Employee> myList = new List<Employee>();

            //foreach (DataRow emps in dt.Rows)
            //{
            //    Employee x = new Employee();
            //    x.EmpID = (int)emps[0];
            //    x.LastName = (string)emps[1];
            //    myList.Add(x);
            //}
            //return myList;
            //Employee myList = new Employee();
       //    PayPeriod x = new PayPeriod();
           int y = 0;
            foreach (DataRow emps in dt.Rows)
            {
                //  x.EmpID = (int)emps[0];
                y = (int)emps[0];
            }
            //return myList;
            return y;
        }
 }
}