using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkDiary.SQLUtility;

namespace WorkDiary.DAL
{
    public class OAAccess
    {
        //private const string SQL_EXECWORKADD = "DECLARE @RC int; DECLARE @ID int; DECLARE @empid int; DECLARE @empname varchar(50); "+
        //    "DECLARE @ldate datetime; DECLARE @content text; DECLARE @econtent text; DECLARE @ltype varchar(50); DECLARE @cdate datetime; "+
        //    "EXECUTE @RC = [dbo].[worklogAddUp] @ID, @empid, @empname, @ldate, @content, @econtent, @ltype, @cdate;";
        private const string SQL_EXECWORKADD = "worklogAddUp";
        private const string SQL_GETUID = "select empid, name from mrbaseinf where empcode = @empcode";

        private const string PARM_EMPCODE = "@empcode";     //工号
        private const string PARM_WORKID = "@ID";           //OA用户ID
        private const string PARM_OAUSER = "@empid";        //工号
        private const string PARM_OANAME = "@empname";      //姓名
        private const string PARM_OADATE = "@ldate";        //日期
        private const string PARM_OACONTENT = "@content";   //内容
        private const string PARM_OAECONTENT = "@econtent"; //标题
        private const string PARM_OATYPE = "@ltype";        //类型
        private const string PARM_OACDATE = "@cdate";       //创建日期

        /// <summary>
        /// 获取OA用户代码
        /// </summary>
        /// <param name="EmpNo">工号</param>
        /// <returns>OA用户代码</returns>
        public static int GetUId(string EmpNo, out string EmpName)
        {
            EmpName = string.Empty;
            //Create a parameter
            SqlParameter parm = new SqlParameter(PARM_EMPCODE, SqlDbType.VarChar, 20);
            parm.Value = EmpNo;

            //Execute a query to read the order
            using (SqlDataReader rdr = SQLHelper.ExecuteReader(Comm.OAConn, CommandType.Text, SQL_GETUID, parm))
            {

                if (rdr.Read())
                {
                    EmpName = rdr.GetString(1);
                    return rdr.GetInt32(0);
                }
            }

            return 0;
        }

        public static void WorkAdd(int workid, int oauser, string oaname, string oadate, string oacontent, string oaecontent, string oatype, string oacdate)
        {
            StringBuilder strSQL = new StringBuilder();

            // Get each commands parameter arrays
            SqlParameter[] Parms = WorkAddParameters();

            SqlCommand cmd = new SqlCommand();

            // Set up the parameters
            Parms[0].Value = workid;
            Parms[1].Value = oauser;
            Parms[2].Value = oaname;
            Parms[3].Value = DateTime.ParseExact(oadate, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            Parms[4].Value = oacontent;
            Parms[5].Value = oaecontent;
            Parms[6].Value = oatype;
            Parms[7].Value = DateTime.ParseExact(oacdate, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);

            foreach (SqlParameter parm in Parms)
                cmd.Parameters.Add(parm);

            // Create the connection to the database
            using (SqlConnection conn = new SqlConnection(Comm.OAConn))
            {

                //StringBuilder strSQL = new StringBuilder();
                //int i = 0;

                ////Append a statement to the batch for each item in the array
                //foreach (LineItemInfo item in items)
                //{

                strSQL.Append(SQL_EXECWORKADD);

                //    inventoryParms = GetInventoryParameters(i);

                //    strSQL.Append("@Quantity").Append(i).Append(" WHERE ItemId = @ItemId").Append(i).Append(";");

                //    //Bind parameters
                //    inventoryParms[0].Value = item.Quantity;
                //    inventoryParms[1].Value = item.ItemId;

                //    foreach (SqlParameter parm in inventoryParms)
                //        cmd.Parameters.Add(parm);
                //    i++;
                //}

                // Open the connection
                conn.Open();

                //Set up the command
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSQL.ToString();

                //Execute the query
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

            }
        }

        /// <summary>
        /// Internal function to get cached parameters
        /// </summary>
        /// <returns></returns>
        private static SqlParameter[] WorkAddParameters()
        {
            SqlParameter[] parms = SQLHelper.GetCachedParameters(SQL_EXECWORKADD);

            if (parms == null)
            {
                parms = new SqlParameter[] {
                    new SqlParameter(PARM_WORKID, SqlDbType.Int),
                    new SqlParameter(PARM_OAUSER, SqlDbType.Int),
                    new SqlParameter(PARM_OANAME, SqlDbType.VarChar, 50),
                    new SqlParameter(PARM_OADATE, SqlDbType.DateTime),
                    new SqlParameter(PARM_OACONTENT, SqlDbType.Text),
                    new SqlParameter(PARM_OAECONTENT, SqlDbType.Text),
                    new SqlParameter(PARM_OATYPE, SqlDbType.VarChar, 50),
                    new SqlParameter(PARM_OACDATE, SqlDbType.DateTime)};

                SQLHelper.CacheParameters(SQL_EXECWORKADD, parms);
            }

            return parms;
        }
    }
}
