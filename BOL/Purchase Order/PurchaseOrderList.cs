using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using SQLLayer;

namespace BOL.Purchase_Order
{
    public class PurchaseOrderList
    {

        /// <summary>
        /// Setter and getter for Purchase Order ID. Primary Key.
        /// </summary>
        int _PurchaseOrderID;
        public int PurchaseOrderID
        {
            get
            {
                return _PurchaseOrderID;
            }
            set
            {
                if (Validation.Int(value))
                {
                    _PurchaseOrderID = value;
                }
                else
                {
                    throw new System.ArgumentException("Order ID cannot be empty.");
                }
            }
        }

        /// <summary>
        /// Gets and sets the employee ID
        /// </summary>
        private int _EmpID;
        public int EmployeeID
        {
            get { return _EmpID; }
            set
            {
                if (Validation.Int(value))
                {
                    _EmpID = value;
                }
                else
                {
                    throw new System.ArgumentException("Employee ID cannot be empty.");
                }
            }
        }

        /// <summary>
        /// Gets and sets the order date
        /// </summary>
        private DateTime _OrderDate;
        public DateTime OrderDate
        {
            get { return _OrderDate; }
            set
            {
                if (value != null)
                {
                    _OrderDate = value;
                }
                else
                {
                    throw new System.ArgumentException("Date cannot be empty.");
                }
            }
        }

        public OrderStatus Status { get; set; }

        /// <summary>
        /// Gets and sets the total
        /// </summary>
        private double _Total;
        public double Total
        {
            get { return _Total; }
            set
            {
                if (Validation.Double(value))
                {
                    _Total = value;
                }
                else
                {
                    throw new ArgumentException("Total cannot be empty.");

                }

            }
        }

        /// <summary>
        /// Gets and sets the employee name
        /// </summary>
        private string _EmployeeName;
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set
            {
                if (Validation.String(value))
                {
                    _EmployeeName = value;
                }
                else
                {
                    throw new System.ArgumentException("Order ID cannot be empty.");
                }
            }
        }




        /// <summary>
        /// Creates a new list of PO's via a search
        /// </summary>
        /// <param name="EmployeeID">Search parm for Emp id</param>
        /// <param name="ID">Search parm for POID </param>
        /// <param name="startdate">Search parm for the start date range</param>
        /// <param name="enddate">Search parm for the end date range</param>
        /// <returns></returns>
        static public List<PurchaseOrderList> Create(int EmployeeID, int ID = -1, DateTime? startdate = null, DateTime? enddate = null)
        {
            return RePackager(PurchaseOrderSQL.searchPO(EmployeeID, ID, startdate, enddate));
        }


        static private List<PurchaseOrderList> RePackager(DataTable dt)
        {
            List<PurchaseOrderList> myList = new List<PurchaseOrderList>();

            foreach (DataRow orders in dt.Rows)
            {
                PurchaseOrderList x = new PurchaseOrderList();
                Employee emp = Employee.retrieve((int)orders[5]);
                x.EmployeeName = emp.FirstName + " " + emp.LastName;
                x.EmployeeID = ((int)orders[5]);
                x.Status = (OrderStatus)int.Parse(orders[2].ToString());
                x.Total = (double.Parse(orders[3].ToString())) + (double.Parse(orders[4].ToString()));
                x.OrderDate = DateTime.Parse(orders[1].ToString());
                x.PurchaseOrderID = (int)orders[0];
                myList.Add(x);
            }
            return myList;
        }
        /// <summary>
        /// Creates a new list of PO's via a search
        /// </summary>
        /// <param name="SupervisorID">Supervisor Id to search by</param>
        /// <param name="status"> status to search by</param>
        /// <param name="firstName"> name to search by</param>
        /// <param name="lastName">name to search by</param>
        /// <param name="startdate"> start date range</param>
        /// <param name="enddate">end date range</param>
        /// <returns></returns>
        static public List<PurchaseOrderList> Create(int SupervisorID, int status = 1, string firstName = null, string lastName = null, DateTime? startdate = null, DateTime? enddate = null)
        {
            if (status == 2)
            {
                return RePackager(PurchaseOrderSQL.searchPO(99, SupervisorID, firstName, lastName, startdate, enddate));
            }
            else {
                return RePackager(PurchaseOrderSQL.searchPO(status, SupervisorID, firstName, lastName, startdate, enddate));
            }
        }
    }
}
