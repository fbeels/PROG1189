
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


        static public DataTable insertEmp(IEmployee emp)           
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.InputOutput, 0, emp.EmpID));
            tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.LastName));
            tmpParmList.Add(new ParmStructure("@middleint", SqlDbType.NChar, ParameterDirection.Input, 0, emp.MiddleInt));
            tmpParmList.Add(new ParmStructure("@firstname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.FirstName));
            tmpParmList.Add(new ParmStructure("@dob", SqlDbType.Date, ParameterDirection.Input, 0, emp.DOB));
            tmpParmList.Add(new ParmStructure("@streetaddress", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Address));
            tmpParmList.Add(new ParmStructure("@city", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.City));
            tmpParmList.Add(new ParmStructure("@prov", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Prov));
            tmpParmList.Add(new ParmStructure("@postal", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Postal));
            tmpParmList.Add(new ParmStructure("@workphone", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Phone));
            tmpParmList.Add(new ParmStructure("@cellphone", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Cell));
            tmpParmList.Add(new ParmStructure("@email", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Email));
            tmpParmList.Add(new ParmStructure("@sinnum", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.SIN));
            tmpParmList.Add(new ParmStructure("@seniorityDate", SqlDbType.Date, ParameterDirection.Input, 0, emp.SeniorityDate));
            tmpParmList.Add(new ParmStructure("@jobstartDate", SqlDbType.Date, ParameterDirection.Input, 0, emp.JobStartDate));
            tmpParmList.Add(new ParmStructure("@JobId", SqlDbType.Int, ParameterDirection.Input, 0, emp.JobID));
            //tmpParmList.Add(new ParmStructure("@DeptId", SqlDbType.Int, ParameterDirection.Input, 0, emp.DeptID));
            tmpParmList.Add(new ParmStructure("@supervisiorID", SqlDbType.Int, ParameterDirection.Input, 0, emp.SupervisorID));
            tmpParmList.Add(new ParmStructure("@payrate", SqlDbType.Decimal, ParameterDirection.Input, 0, emp.PayRate));
           // tmpParmList.Add(new ParmStructure("@terminationDate", SqlDbType.Date, ParameterDirection.Input, 0, emp.TerminationDate));
            tmpParmList.Add(new ParmStructure("@emailnotificatoins", SqlDbType.Bit, ParameterDirection.Input, 0, emp.EmailNotification));

            return DataAccess.GetDataTable("InsertEmployee", tmpParmList);
        }




        public static DataTable UpdateEmp(IEmployee emp)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.InputOutput, 0, emp.EmpID));
            tmpParmList.Add(new ParmStructure("@lastname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.LastName));
            tmpParmList.Add(new ParmStructure("@middleint", SqlDbType.NChar, ParameterDirection.Input, 0, emp.MiddleInt));
            tmpParmList.Add(new ParmStructure("@firstname", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.FirstName));
            tmpParmList.Add(new ParmStructure("@dob", SqlDbType.Date, ParameterDirection.Input, 0, emp.DOB));
            tmpParmList.Add(new ParmStructure("@streetaddress", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Address));
            tmpParmList.Add(new ParmStructure("@city", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.City));
            tmpParmList.Add(new ParmStructure("@prov", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Prov));
            tmpParmList.Add(new ParmStructure("@postal", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Postal));
            tmpParmList.Add(new ParmStructure("@workphone", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Phone));
            tmpParmList.Add(new ParmStructure("@cellphone", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Cell));
            tmpParmList.Add(new ParmStructure("@email", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.Email));
            tmpParmList.Add(new ParmStructure("@sinnum", SqlDbType.VarChar, ParameterDirection.Input, 0, emp.SIN));
            tmpParmList.Add(new ParmStructure("@seniorityDate", SqlDbType.Date, ParameterDirection.Input, 0, emp.SeniorityDate));
            tmpParmList.Add(new ParmStructure("@jobstartDate", SqlDbType.Date, ParameterDirection.Input, 0, emp.JobStartDate));
            tmpParmList.Add(new ParmStructure("@JobId", SqlDbType.Int, ParameterDirection.Input, 0, emp.JobID));
            //tmpParmList.Add(new ParmStructure("@DeptId", SqlDbType.Int, ParameterDirection.Input, 0, emp.DeptID));
            tmpParmList.Add(new ParmStructure("@supervisiorID", SqlDbType.Int, ParameterDirection.Input, 0, emp.SupervisorID));
            tmpParmList.Add(new ParmStructure("@payrate", SqlDbType.Decimal, ParameterDirection.Input, 0, emp.PayRate));
            // tmpParmList.Add(new ParmStructure("@terminationDate", SqlDbType.Date, ParameterDirection.Input, 0, emp.TerminationDate));
            tmpParmList.Add(new ParmStructure("@emailnotificatoins", SqlDbType.Bit, ParameterDirection.Input, 0, emp.EmailNotification));

            return DataAccess.GetDataTable("UpdateEmployee", tmpParmList);
        }
    }//end of class
}//end of namespace
