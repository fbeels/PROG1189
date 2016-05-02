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
    static public class PayRollSQL
    {
        static public DataTable RunPayRoll(string strpasscode)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@passcode", SqlDbType.VarChar, ParameterDirection.Input, 10, strpasscode));
            return DataAccess.GetDataTable("RunPayroll2", tmpParmList);
        }
    }
}
