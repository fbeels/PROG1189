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

            return DataAccess.GetDataTable("GetPOByID", tmpParmList);
        }

        static public Dictionary<string, int> createInitialPO(IPurchaseOrderItem item, IPurchaseOrder PO)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@tax", SqlDbType.Float, ParameterDirection.Input, 0, PO.Tax));
            tmpParmList.Add(new ParmStructure("@subtotal", SqlDbType.Float, ParameterDirection.Input, 0, PO.SubTotal));
            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.Input, 0, PO.EmployeeID));
            tmpParmList.Add(new ParmStructure("@orderdate", SqlDbType.Date, ParameterDirection.Input, 0, DateTime.Now));
            tmpParmList.Add(new ParmStructure("@orderstatus", SqlDbType.TinyInt, ParameterDirection.Input, 0, OrderStatus.Pending));
            tmpParmList.Add(new ParmStructure("@poid", SqlDbType.Int, ParameterDirection.Output, 10, null));

            DataAccess.SendData("insertPO", tmpParmList);

            int id = int.Parse(tmpParmList[5].ParmValue.ToString());
            item.PurchaseOrderID = id;
            int iid = PurchaseOrderItemSQL.insertPurchaseOrderItem(item);
            var dict = new Dictionary<string, int>
            {
                {"POID", id },
                {"ItemID", iid }
            };
            return dict;
        }

        static public bool modifyPO(IPurchaseOrder PO)
        {
            List<ParmStructure> tmpParmList = new List<ParmStructure>();
            tmpParmList.Add(new ParmStructure("@poid", SqlDbType.Int, ParameterDirection.Input, 0, PO.PurchaseOrderID));
            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.Input, 0, PO.EmployeeID));
            tmpParmList.Add(new ParmStructure("@tax", SqlDbType.Float, ParameterDirection.Input, 9, PO.Tax));
            tmpParmList.Add(new ParmStructure("@subtotal", SqlDbType.Float, ParameterDirection.Input, 9, PO.SubTotal));
            tmpParmList.Add(new ParmStructure("@orderdate", SqlDbType.Date, ParameterDirection.Input, 0, DateTime.Now));
            tmpParmList.Add(new ParmStructure("@orderstatus", SqlDbType.TinyInt, ParameterDirection.Input, 0, PO.Status));

            DataAccess.SendData("UpdatePO", tmpParmList);

            return true;
        }

        static public DataTable searchPO(int empid, int ID = -1, DateTime? startdate = null, DateTime? enddate = null)
        {
            var eStartDate = startdate ?? DateTime.MinValue;
            var eEndDate = enddate ?? DateTime.MinValue;

            List<ParmStructure> tmpParmList = new List<ParmStructure>();

            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.Input, 0, empid));

            if (ID != 0)
            {
                tmpParmList.Add(new ParmStructure("@poid", SqlDbType.Int, ParameterDirection.Input, 0, ID));
                return DataAccess.GetDataTable("GetPOByIDAndEmpID", tmpParmList);
            }
            else if (eStartDate != DateTime.MinValue & eEndDate != DateTime.MinValue)
            {
                tmpParmList.Add(new ParmStructure("@startdate", SqlDbType.Date, ParameterDirection.Input, 0, eStartDate));
                tmpParmList.Add(new ParmStructure("@enddate", SqlDbType.Date, ParameterDirection.Input, 0, eEndDate));
                return DataAccess.GetDataTable("GetPOByDate", tmpParmList);
            }
            return null;
        }


        static public DataTable searchPO(OrderStatus status, string EmpName, int SupervisorID, DateTime? startdate = null, DateTime? enddate = null)
        {
            var eStartDate = startdate ?? DateTime.MinValue;
            var eEndDate = enddate ?? DateTime.MinValue;

            List<ParmStructure> tmpParmList = new List<ParmStructure>();

            tmpParmList.Add(new ParmStructure("@empid", SqlDbType.Int, ParameterDirection.Input, 0, SupervisorID));

            tmpParmList.Add(new ParmStructure("@startdate", SqlDbType.Date, ParameterDirection.Input, 0, eStartDate));
            tmpParmList.Add(new ParmStructure("@enddate", SqlDbType.Date, ParameterDirection.Input, 0, eEndDate));
            return DataAccess.GetDataTable("GetPOByDate", tmpParmList);
        }

    }
}
