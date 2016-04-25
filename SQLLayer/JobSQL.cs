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
    static public class JobSQL
    {
        public static System.Data.DataTable retrieveDepartments()
        {
            throw new NotImplementedException();
        }


        static public DataTable GetAllJobs4Dropdowns(int dept)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@deptid", SqlDbType.Int, ParameterDirection.Input, 0, dept));
            return DataAccess.GetDataTable("GetJobsInDept", tmpParmList);
        }

      

    }
}
