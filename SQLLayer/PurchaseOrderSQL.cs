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
    static public class PurchaseOrderSQL
    {
        static public DataTable retrievePurchaseOrder(int PO_ID)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@poid", SqlDbType.Int, ParameterDirection.Input, 0, PO_ID));

            return DataAccess.GetDataTable("getPOByID", tmpParmList);
        }

        static public bool createInitialPO(IPurchaseOrderItem item, IPurchaseOrder PO)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@tax", SqlDbType.Float, ParameterDirection.Input, 0, PO.Tax));
            tmpParmList.Add(new ParmStructure("@subtotal", SqlDbType.Float, ParameterDirection.Input, 0, PO.SubTotal));
            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.Input, 0, PO.EmployeeID));
            tmpParmList.Add(new ParmStructure("@orderdate", SqlDbType.Date, ParameterDirection.Input, 0, DateTime.Now));
            tmpParmList.Add(new ParmStructure("@status", SqlDbType.TinyInt, ParameterDirection.Input, 0, OrderStatus.Pending));

            int id = DataAccess.SendData("insertPO", tmpParmList);
            item.PurchaseOrderID = id;
            PurchaseOrderItemSQL.insertPurchaseOrderItem(item);
            return true;
        }

        static public bool modifyPO(IPurchaseOrder PO)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@poid", SqlDbType.Int, ParameterDirection.Input, 0, PO.PurchaseOrderID));
            tmpParmList.Add(new ParmStructure("@tax", SqlDbType.Float, ParameterDirection.Input, 9, PO.Tax));
            tmpParmList.Add(new ParmStructure("@subtotal", SqlDbType.Float, ParameterDirection.Input, 9, PO.SubTotal));
            tmpParmList.Add(new ParmStructure("@orderdate", SqlDbType.Date, ParameterDirection.Input, 0, DateTime.Now));

            DataAccess.SendData("modifyPO", tmpParmList);
            return true;
        }


        static public bool modifyPOStatus(int PO_ID, OrderStatus status)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@poid", SqlDbType.Int, ParameterDirection.Input, 0, PO_ID));
            tmpParmList.Add(new ParmStructure("@status", SqlDbType.TinyInt, ParameterDirection.Input, 0, status));
            DataAccess.SendData("modifyPOStatus", tmpParmList);
            return true;
        }

    }
}
