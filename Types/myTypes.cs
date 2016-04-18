using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace MyTypes
{
    public enum ItemStatus
    {
        Pending,
        Approved,
        Denied
    }

    public enum OrderStatus
    {
        Pending,
        UnderReview,
        Closed
    }


    public struct ParmStructure
    {
        private string ParmID_;
        private SqlDbType ParmDataType_;
        private int ParmSize_;
        private ParameterDirection ParmDirection_;
        private object ParmValue_;
        public string ParmID
        {
            get { return ParmID_; }
        }
        public SqlDbType ParmDataType
        {
            get { return ParmDataType_; }
        }
        public int ParmSize
        {
            get { return ParmSize_; }
        }
        public System.Data.ParameterDirection ParmDirection
        {
            get { return ParmDirection_; }
        }
        public object ParmValue
        {
            get { return ParmValue_; }
            set { ParmValue_ = value; }
        }


        public ParmStructure(string myParmID, SqlDbType myParmDataType, ParameterDirection myParmDirection, int myParmSize = 0, object myParmValue = null)
        {
            ParmID_ = myParmID;
            ParmDataType_ = myParmDataType;
            ParmSize_ = myParmSize;
            ParmDirection_ = myParmDirection;
            ParmValue_ = myParmValue;
        }
    }

}
