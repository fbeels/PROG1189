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
                myList.Add(x);
            }
            return myList;
        }
    }

}







   

