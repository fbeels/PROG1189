using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Common;
using SQLLayer;

namespace BOL
{
    static class DepartmentFactory
    {

        static public List<Department> Create()
        {
            DataTable depttable = DepartmentSQL.retrieveDepartments();
            return Repackager(depttable);
        }
        static private List<Department> Repackager(DataTable depttable)
        {
            //Department dep = new Department();
            List<Department> deps = new List<Department>();
            Department dept = new Department();

            foreach (DataRow row in depttable.Rows)
            {
                BOL.Department.Department.
                dept.DeptID= int.Parse(row["deptid"].ToString());
                dept.DeptName = row["deptname"].ToString();
                deps.Add(dept);
            }
            return deps;
        }


    }
}
