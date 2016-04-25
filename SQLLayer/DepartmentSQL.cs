
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

    }
}
