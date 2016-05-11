using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using BOL.Purchase_Order_Item;
using SQLLayer;
using System.Data.Sql;
using System.Data;

namespace BOL.Purchase_Order
{
    [Serializable]
    public class PurchaseOrder : IPurchaseOrder
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

        /// <summary>
        /// Gets and sets subtotal
        /// </summary>
        private double _SubTotal;
        public double SubTotal
        {
            get { return _SubTotal; }
            set
            {
                if (Validation.Double(value))
                {
                    _SubTotal = value;
                }
                else
                {
                    throw new ArgumentException("Sub total cannot be empty.");

                }

            }
        }

        /// <summary>
        /// Gets and set the tax
        /// </summary>
        private double _Tax;
        public double Tax
        {
            get { return _Tax; }
            set
            {
                if (Validation.Double(value))
                {
                    _Tax = value;
                }
                else
                {
                    throw new ArgumentException("Tax cannot be empty.");

                }

            }
        }

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
        /// Gets and sets the status
        /// </summary>
        public OrderStatus Status { get; set; }
        /// <summary>
        /// Gets and sets the items.
        /// </summary>
        public List<PurchaseOrderItem> Items { get; set; }


        private int _lastupdated;        
        public int lastudpated
        {
            get { return _lastupdated; }
            set { _lastupdated = value; }
        }


        const double tax = .13;


        private double subtotal;
        private double taxamnt;
        private double total;

        /// <summary>
        /// Calculates the subtotal of all items
        /// </summary>
        /// <returns></returns>
        public double calculateSubtotal()
        {
            subtotal = 0;
            foreach (PurchaseOrderItem item in Items)
            {
                subtotal += item.calculateSubtotal();
            }

            return subtotal;
        }

        /// <summary>
        /// Calculates the tax of all items.
        /// </summary>
        /// <returns></returns>
        public double calculateTax()
        {
            taxamnt = subtotal * tax;
            return taxamnt;
        }


        /// <summary>
        /// Calculates the total of all items.
        /// </summary>
        /// <returns></returns>
        public double calculateTotal()
        {
            total = subtotal + taxamnt;
            return total;
        }

        /// <summary>
        /// Closes the order.
        /// </summary>
        /// <param name="PO">Order to close</param>
        public static void closeOrder(PurchaseOrder PO)
        {
            PO.Status = OrderStatus.Closed;
            PurchaseOrderSQL.modifyPO(PO);
            PurchaseOrderSQL.closeEmail(PO);
        }


        /// <summary>
        /// Marks an item as under review
        /// </summary>
        /// <param name="PO">Order to mark as under review</param>
        public static void markUnderReview(PurchaseOrder PO)
        {
            PO.Status = OrderStatus.UnderReview;
            PurchaseOrderSQL.modifyPO(PO);
        }

        /// <summary>
        /// Marks an item as pending
        /// </summary>
        /// <param name="PO">Order to mark as pending</param>
        public static void markPending(PurchaseOrder PO)
        {
            PO.Status = OrderStatus.Pending;
            PurchaseOrderSQL.modifyPO(PO);
        }
       
    }
}
