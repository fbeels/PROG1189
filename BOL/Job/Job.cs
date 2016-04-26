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
    
        public class Job
        {
            public int JobId { get; set; }
            public String JobName { get; set; }
            public int DeptId { get; set; }
            public double minbiweekly { get; set; }
            public double maxbiweekly { get; set; }

        static public List<Job> GetAllJobs4Dropdowns(int dept)
        {
            return GetAllJobs4DropdownsRePackager(JobSQL.GetAllJobs4Dropdowns(dept));
        }


        static private List<Job> GetAllJobs4DropdownsRePackager(DataTable dt)
        {
            List<Job> myList = new List<Job>();

            foreach (DataRow deps in dt.Rows)
            {
                Job x = new Job();
                x.JobId= (int)deps[0];
                x.JobName = (string)deps[1];
                myList.Add(x);
            }
            return myList;
        }
    }

}