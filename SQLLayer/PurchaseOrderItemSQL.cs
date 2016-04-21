using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DAL;

namespace SQLLayer
{
    static public class PurchaseOrderItemSQL
    {
        static public DataTable retrievePurchaseOrderItem(int POItem_ID)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@poItemid", SqlDbType.Int, ParameterDirection.Input, 0, POItem_ID));

            return DataAccess.GetDataTable("getPOItemByID", tmpParmList);
        }

        static public int insertPurchaseOrderItem(IPurchaseOrderItems POI)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@po_id", SqlDbType.Int, ParameterDirection.Input, 0, POI.PurchaseOrderID));
            tmpParmList.Add(new ParmStructure("@itemname", SqlDbType.VarChar, ParameterDirection.Input, 50, POI.ItemName));
            tmpParmList.Add(new ParmStructure("@desc", SqlDbType.VarChar, ParameterDirection.Input, 50, POI.Description));
            tmpParmList.Add(new ParmStructure("@quantity", SqlDbType.Int, ParameterDirection.Input, 50, POI.Quantity));
            tmpParmList.Add(new ParmStructure("@price", SqlDbType.Float, ParameterDirection.Input, 50, POI.Price));
            tmpParmList.Add(new ParmStructure("@reason", SqlDbType.VarChar, ParameterDirection.Input, 50, POI.Reason));
            tmpParmList.Add(new ParmStructure("@source", SqlDbType.VarChar, ParameterDirection.Input, 50, POI.Source));
            tmpParmList.Add(new ParmStructure("@justification", SqlDbType.VarChar, ParameterDirection.Input, 50, POI.Justification));

            return DataAccess.SendData("getPOItemByID", tmpParmList);
        }


        static public DataTable retrievePurchaseOrderItemByOrderID(int PO_ID)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@poid", SqlDbType.Int, ParameterDirection.Input, 0, PO_ID));

            return DataAccess.GetDataTable("getPOItemByOrderID", tmpParmList);
        }

    }
}
