using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using WorkDiary.OracleUtility;

namespace WorkDiary.DAL
{
    public class Comm
    {
        // Read the connection strings from the configuration file
        public static readonly string DBConn = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        public static readonly string ITSMConn = ConfigurationManager.ConnectionStrings["ITSMDB"].ConnectionString;
        public static readonly string OAConn = ConfigurationManager.ConnectionStrings["OADB"].ConnectionString;

        //public static DataTable GetData(string connStr, string sqlstr, params OracleParameter[] parm)
        //{
        //    DataTable dt = new DataTable();
        //    //Execute a query to read the order
        //    using (OracleDataReader rdr = OracleHelper.ExecuteReader(connStr, CommandType.Text, sqlstr, parm))
        //    {
        //        int intFieldCount = rdr.FieldCount;
        //        for (int intCounter = 0; intCounter < intFieldCount; intCounter++)
        //        {
        //            dt.Columns.Add(rdr.GetName(intCounter), rdr.GetFieldType(intCounter));
        //        }
        //        dt.BeginLoadData();
        //        object[] objValues = new object[intFieldCount];
        //        while (rdr.Read())
        //        {
        //            rdr.GetValues(objValues);
        //            dt.LoadDataRow(objValues, true);
        //        }
        //        dt.EndLoadData();
        //    }
        //    return dt;
        //}

        public static DataTable GetData(string connStr, string sqlstr)
        {
            DataTable dt = new DataTable();
            //Execute a query to read the order
            using (OracleDataReader rdr = OracleHelper.ExecuteReader(connStr, CommandType.Text, sqlstr))
            {
                int intFieldCount = rdr.FieldCount;
                for (int intCounter = 0; intCounter < intFieldCount; intCounter++)
                {
                    dt.Columns.Add(rdr.GetName(intCounter), rdr.GetFieldType(intCounter));
                }
                dt.BeginLoadData();
                object[] objValues = new object[intFieldCount];
                while (rdr.Read())
                {
                    rdr.GetValues(objValues);
                    dt.LoadDataRow(objValues, true);
                }
                dt.EndLoadData();
            }
            return dt;
        }
    }
}
