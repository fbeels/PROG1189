using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   
    public interface IDepartment
    {
        public int DeptID { get; set; }
        public String DeptName { get; set; }
    }
}