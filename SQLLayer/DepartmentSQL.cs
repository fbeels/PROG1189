
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
    public class DepartmentSQL
    {
      


        static public DataTable GetAllDepts()
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            return DataAccess.GetDataTable("GetDepartments", tmpParmList);
        }


        public static DataTable GetADept(int deptid)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@deptid", SqlDbType.Int, ParameterDirection.Input, 0, deptid));
            return DataAccess.GetDataTable("GetDeptwithDeptID", tmpParmList);
        }
    }
}
