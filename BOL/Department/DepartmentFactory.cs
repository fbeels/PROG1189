//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using Common;
//using SQLLayer;

//namespace BOL
//{
//    static class DepartmentFactory
//    {

//        static public List<Deptartment> Create()
//        {
//            DataTable depttable = DepartmentSQL.retrieveDepartments();
//            return Repackager(depttable);
//        }
//        static private List<Dept> Repackager(DataTable depttable)
//        {
//            //Department dep = new Department();
//            List<Dept> deps = new List<Dept>();
//            Dept dept = new Dept();

//            foreach (DataRow row in depttable.Rows)
//            {
//                //BOL.Dept.Department.
//                //dept.DeptID= int.Parse(row["deptid"].ToString());
//                //dept.DeptName = row["deptname"].ToString();
//                //deps.Add(dept);
//            }
//            return deps;
//        }


//    }
//}
