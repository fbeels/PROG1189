﻿using System;
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

        static public int insertPurchaseOrderItem(IPurchaseOrderItem item)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@po_id", SqlDbType.Int, ParameterDirection.Input, 0, item.PurchaseOrderID));
            tmpParmList.Add(new ParmStructure("@itemname", SqlDbType.VarChar, ParameterDirection.Input, 50, item.ItemName));
            tmpParmList.Add(new ParmStructure("@desc", SqlDbType.VarChar, ParameterDirection.Input, 50, item.Description));
            tmpParmList.Add(new ParmStructure("@quantity", SqlDbType.Int, ParameterDirection.Input, 50, item.Quantity));
            tmpParmList.Add(new ParmStructure("@price", SqlDbType.Float, ParameterDirection.Input, 50, item.Price));
            tmpParmList.Add(new ParmStructure("@reason", SqlDbType.VarChar, ParameterDirection.Input, 50, item.Reason));
            tmpParmList.Add(new ParmStructure("@source", SqlDbType.VarChar, ParameterDirection.Input, 50, item.Source));
            tmpParmList.Add(new ParmStructure("@justification", SqlDbType.VarChar, ParameterDirection.Input, 50, item.Justification));
            tmpParmList.Add(new ParmStructure("@orderstatus", SqlDbType.Int, ParameterDirection.Input, 0, item.Status));

            return DataAccess.SendData("insertPOItem", tmpParmList);
        }


        static public DataTable retrievePurchaseOrderItemByOrderID(int PO_ID)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@poid", SqlDbType.Int, ParameterDirection.Input, 0, PO_ID));

            return DataAccess.GetDataTable("getPOItemByOrderID", tmpParmList);
        }

       
        static public bool modifyItem(IPurchaseOrderItem item)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@poItemid", SqlDbType.Int, ParameterDirection.Input, 0, item.PurchaseOrderID));
            tmpParmList.Add(new ParmStructure("@po_id", SqlDbType.Int, ParameterDirection.Input, 0, item.PurchaseOrderID));
            tmpParmList.Add(new ParmStructure("@itemname", SqlDbType.VarChar, ParameterDirection.Input, 50, item.ItemName));
            tmpParmList.Add(new ParmStructure("@desc", SqlDbType.VarChar, ParameterDirection.Input, 50, item.Description));
            tmpParmList.Add(new ParmStructure("@quantity", SqlDbType.Int, ParameterDirection.Input, 50, item.Quantity));
            tmpParmList.Add(new ParmStructure("@price", SqlDbType.Float, ParameterDirection.Input, 50, item.Price));
            tmpParmList.Add(new ParmStructure("@reason", SqlDbType.VarChar, ParameterDirection.Input, 50, item.Reason));
            tmpParmList.Add(new ParmStructure("@source", SqlDbType.VarChar, ParameterDirection.Input, 50, item.Source));
            tmpParmList.Add(new ParmStructure("@justification", SqlDbType.VarChar, ParameterDirection.Input, 50, item.Justification));

            DataAccess.SendData("modifyItem", tmpParmList);
            return true;
        }

    }
}
