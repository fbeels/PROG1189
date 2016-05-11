using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Purchase_Order;
using Common;

namespace BOL.Purchase_Order_Item
{
    [Serializable]
    public class PurchaseOrderItem : IPurchaseOrderItem
    {
        /// <summary>
        /// Setter and getter for Item ID. Primary Key
        /// </summary>
        int _ItemID;
        public int ItemID
        {
            get
            {
                return _ItemID;
            }
            set
            {
                if (Validation.Int(value) == true || value == -1)
                {
                    _ItemID = value;
                }
                else
                {
                    throw new System.ArgumentException("Item ID cannot be empty.");
                }

            }

        }

        /// <summary>
        /// Setter and getter for Purchase Order ID. Foreign Key.
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
        /// Setter and getter for itemname
        /// </summary>
        string _ItemName;
        public string ItemName
        {
            get
            {
                return _ItemName;
            }
            set
            {
                if (Validation.String(value))
                {
                    _ItemName = value;
                }
                else
                {
                    throw new System.ArgumentException("Item name cannot be empty.");
                }

            }

        }

       /// <summary>
       /// Setter and getter for description
       /// </summary>
        string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (Validation.String(value))
                {
                    _description = value;
                }
                else
                {
                    throw new System.ArgumentException("Item description cannot be empty.");
                }

            }

        }

        /// <summary>
        /// Setter and getter for quantity
        /// </summary>
        int _Quantity;
        public int Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                if (Validation.Int(value))
                {
                    _Quantity = value;
                }
                else
                {
                    throw new System.ArgumentException("Quantity cannot be empty.");
                }

            }

        }

        /// <summary>
        /// Setter and getter for price
        /// </summary>
        private double _Price;
        public double Price
        {
            get { return _Price; }
            set
            {
                if (Validation.Double(value))
                {
                    _Price = value;
                }
                else
                {
                    throw new System.ArgumentException("Price cannot be empty.");
                }

            }
        }

        /// <summary>
        /// Setter and getter for source
        /// </summary>
        private string _Source;
        public string Source
        {
            get { return _Source; }
            set
            {
                if (Validation.String(value))
                {
                    _Source = value;
                }
                else
                {
                    throw new System.ArgumentException("Source cannot be empty.");
                }

            }
        }
        
        /// <summary>
        /// Setter and getter for justification
        /// </summary>
        private string _Justification;
        public string Justification
        {
            get { return _Justification; }
            set
            {
                if (Validation.String(value))
                {
                    _Justification = value;
                }
                else
                {
                    throw new System.ArgumentException("Justification cannot be empty.");
                }

            }
        }

        /// <summary>
        /// Setter and getter for ItemStatus
        /// </summary>
        private ItemStatus _Status;
        public ItemStatus Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        /// <summary>
        /// Setter and getter for Reason
        /// </summary>
        private string _Reason;
        public string Reason
        {
            get { return _Reason; }
            set { _Reason = value; }
        }



        private int _lastupdated;
        public int lastupdated
        {
            get { return _lastupdated; }
            set { _lastupdated = value; }
        }


        /// <summary>
        /// Calculates the subtotal of item
        /// </summary>
        /// <returns></returns>
        public double calculateSubtotal()
        {
            return Price * Quantity;
        }

        /// <summary>
        /// Approves the item in the Purchase Order
        /// </summary>
        /// <param name="item">Item to approve</param>
        static public void approveItem(PurchaseOrderItem item)
        {
            item.Status = ItemStatus.Approved;

            SQLLayer.PurchaseOrderItemSQL.modifyItem(item);
        }

        /// <summary>
        /// Denies the item in the purchase order, with a reason
        /// </summary>
        /// <param name="item">Item to deny</param>
        /// <param name="reason">Reason for denial</param>
        static public void denyItem(PurchaseOrderItem item, string reason)
        {
            item.Status = ItemStatus.Denied;
            item.Reason = reason;

            SQLLayer.PurchaseOrderItemSQL.modifyItem(item);
        }

        /// <summary>
        /// Marks an item as no longer needed
        /// </summary>
        /// <param name="item">Item to mark.</param>
        static public void noLongerNeeded(PurchaseOrderItem item)
        {
            item.Description = "No longer needed";
            item.Price = 0;
            item.Quantity = 0;
            item.Status = ItemStatus.Denied;
        }
    }


}
