
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
        static public Boolean IsItPayday()
        {
            return IsItPaydayRePackager(PayPeriodSQL.IsItPayday());
        }

        static private Boolean IsItPaydayRePackager(DataTable dt)
        {
            //List<Employee> myList = new List<Employee>();
            PayPeriod x = new PayPeriod();
            //int itest=0;
            foreach (DataRow pay in dt.Rows)
            {
            //    Employee x = new Employee();
                x.Payrollid = (int)pay[0];
            //    x.EmpID = (int)emps[0];
            //    x.LastName = (string)emps[1];
            //    myList.Add(x);
            }
            //return myList;
            //Employee myList = new Employee();
       //    

           
            if (x.Payrollid == 9999)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        static public Boolean HasPayBeenRun()
        {
            return HasPayBeenRunRePackager(PayPeriodSQL.HasPayBeenRun());
        }
        static private Boolean HasPayBeenRunRePackager(DataTable dt)
        {
            //List<Employee> myList = new List<Employee>();
                PayPeriod x = new PayPeriod();
            foreach (DataRow pay in dt.Rows)
            {
               
                x.hasbeenprocesed=  (bool)pay[0];
            //    x.LastName = (string)emps[1];
            //    myList.Add(x);
            }
            return x.hasbeenprocesed;
            //Employee myList = new Employee();
            //    PayPeriod x = new PayPeriod();


            //if (dt.Rows.Count == 1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}


        }


 }//end of class
}//end of namespace