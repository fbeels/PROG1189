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
    
        public class Department
        {
            public int DeptID { get; set; }
            public String DeptName { get; set; }
            public int SupervisorId { get; set; }
            public String SupervisorName { get; set; }
        

            static public List<Department> GetAllDepts()
             {
                return GetAllDeptsRePackager(DepartmentSQL.GetAllDepts());
            }


            static private List<Department> GetAllDeptsRePackager(DataTable dt)
            {
                List<Department> myList = new List<Department>();

                foreach (DataRow deps in dt.Rows)
                {
                Department x = new Department();
                x.DeptID = (int)deps[0];
                x.DeptName = (string)deps[1];
                x.SupervisorId = (int)deps[2];
                x.SupervisorName = (string)deps[3];
                myList.Add(x);
                }
                return myList;
            }

            static public Department GetADept(int deptid)
            {
                return GetADeptRePackager(DepartmentSQL.GetADept(deptid));
            }


            static private Department GetADeptRePackager(DataTable dt)
            {
                //List<Department> myList = new List<Department>();
                Department mydept = new Department();

                foreach (DataRow deps in dt.Rows)
                {
                   // Department x = new Department();
                    mydept.DeptID = (int)deps[0];
                    mydept.DeptName = (string)deps[1];
                    mydept.SupervisorId = (int)deps[2];
                    mydept.SupervisorName = (string)deps[3];
                   // myList.Add(x);
                }
                return mydept;
            }

        }//end of class

}//end of namespace







   

