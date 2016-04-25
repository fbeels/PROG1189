
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
    static public class EmployeeSQL
    {
        static public DataTable searchEmp(int search_empid, string search_lname)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.Input, 0, search_empid));
            tmpParmList.Add(new ParmStructure("@lname", SqlDbType.VarChar, ParameterDirection.Input, 50, search_lname));
            return DataAccess.GetDataTable("SearchEmps", tmpParmList);
        }
        static public DataTable retrieveEmp(int empid)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.Input, 0, empid));
            return DataAccess.GetDataTable("GetEmployeeWithId", tmpParmList);
        }
        static public DataTable GetAllEmpsInDept(int deptid)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@deptid", SqlDbType.Int, ParameterDirection.Input, 0, deptid));
            return DataAccess.GetDataTable("GetAllEmpsInDept", tmpParmList);
        }


        // static public DataTable insertEmp(Employee emp)
        //{
        //    List<ParmStructure> tmpParmList = new List<ParmStructure>();
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Int, ParameterDirection.InputOutput, 0, emp.EmpID));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.LastName));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.NChar, ParameterDirection.Input, 0, emp.MiddleInt));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.FirstName));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Date, ParameterDirection.Input, 0, emp.DOB));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Address));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.City));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Prov));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Postal));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Phone));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Cell));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Email));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.SIN));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Date, ParameterDirection.Input, 0, emp.SeniorityDate));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Date, ParameterDirection.Input, 0, emp.JobStartDate));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Int, ParameterDirection.Input, 0, emp.JobID));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Int, ParameterDirection.Input, 0, emp.DeptID));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Int, ParameterDirection.Input, 0, emp.SupervisorID));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Decimal, ParameterDirection.Input, 0, emp.PayRate));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Date, ParameterDirection.Input, 0, emp.TerminationDate));
        //    tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.Bit, ParameterDirection.Input, 0, emp.EmailNotification));
    
        //return DataAccess.GetDataTable("GetAllEmpsInDept", tmpParmList);
        //}


       
    }//end of class
}//end of namespace
