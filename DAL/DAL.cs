
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using MyTypes;

namespace DAL
{
    public class DataAccess
    {
        public static DataTable GetDataTable(string sproc, List<ParmStructure> parms = null)
        {
            SqlCommand cmd = CreateCommandObject(sproc, parms);
            SqlConnection cnn = new SqlConnection(DALCnn.getConnectionString());
            using (cnn)
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cnn;
                DataTable dt = new DataTable();
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                da.Fill(dt);
                return dt;
            }
        }
        public static int SendData(string sproc, List<ParmStructure> parms = null)
        {
            SqlCommand cmd = CreateCommandObject(sproc, parms);
            using (SqlConnection cnn = new SqlConnection(DALCnn.getConnectionString()))
            {
                cmd.Connection = cnn;
                cnn.Open();
                int x = 0;
                x = cmd.ExecuteNonQuery();
                UnloadCommandObject(parms, cmd);
                cnn.Close();
                return x;
            }
        }
        private static SqlCommand CreateCommandObject(string sproc, List<ParmStructure> parms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sproc;
            cmd.CommandType = CommandType.StoredProcedure;

            if ((parms != null))
            {
                for (int i = 0; i <= parms.Count - 1; i++)
                {
                    cmd.Parameters.AddWithValue(parms.Item(i).ParmID, parms.Item(i).ParmDataType);
                    if (parms.Item(i).ParmSize != 0)
                    {
                        cmd.Parameters(parms.Item(i).ParmID).Size = parms.Item(i).ParmSize;
                    }
                    else {
                        cmd.Parameters(parms.Item(i).ParmID).Size = 0;
                    }

                    cmd.Parameters(parms.Item(i).ParmID).Value = parms.Item(i).ParmValue;

                    cmd.Parameters(parms.Item(i).ParmID).Direction = parms.Item(i).ParmDirection;
                }
            }
            return cmd;
        }
        private static void UnloadCommandObject(List<ParmStructure> parm, SqlCommand cmd)
        {
            if ((parm != null))
            {
                for (int i = 0; i <= parm.Count - 1; i++)
                {
                    ParmStructure x = parm(i);
                    x.ParmValue = cmd.Parameters(i).Value;
                    parm(i) = x;
                }
            }
        }
    }
}
