using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;
using System.Data;


namespace SQLLayer
{
    static public class PayPeriodSQL
    {
        //static public DataTable searchEmp(int search_empid, string search_lname)
        //{
        //    List<ParmStructure> tmpParmList = new List<ParmStructure>();
        //    tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.Input, 0, search_empid));
        //    tmpParmList.Add(new ParmStructure("@lname", SqlDbType.VarChar, ParameterDirection.Input, 50, search_lname));
        //    return DataAccess.GetDataTable("SearchEmps", tmpParmList);
        //}

         static public DataTable IsItPayday()
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            return DataAccess.GetDataTable("IsPayday", tmpParmList);
        }
    }
}
