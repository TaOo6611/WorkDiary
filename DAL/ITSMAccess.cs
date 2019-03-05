using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using WorkDiary.Model;

namespace WorkDiary.DAL
{
    public class ITSMAccess
    {
        private const string SQL_GETLIST = "select i.incidentno 编号, DATE_FORMAT(i.createdate, '%Y%m%d%H%i%s') 时间, "+
            "d.TreeNo departtree, case when length(d.TreeNo) <= 8 then d.DepartmentName else " +
            "(select d1.DepartmentName from t_department d1 where d1.TreeNo = substr(d.TreeNo, 1, 8)) end 科室, "+
            "s.TreeNo servicetree, s.ItilServiceName 服务, i.incidenttitle 事件, i.incidentdescription 详情, i.process 处理 "+
            "from t_incident i, t_user uc, t_department d, t_itilservice s " +
            "where i.CreateUserId = uc.UserID and uc.AccountName = ?uid and i.DepartmentID = d.DepartmentID and i.FinalSupportItilServiceID = s.ItilServiceID " +
            "and i.UpdateDate >= str_to_date(?strdate, '%Y-%m-%d') and i.UpdateDate < date_add(str_to_date(?strdate, '%Y-%m-%d'), INTERVAL 1 day) " +
            "and i.CurrentState >= '99'";
        private const string SQL_GETOPEN = "select i.incidentno 编号, DATE_FORMAT(i.createdate, '%Y%m%d%H%i%s') 时间, " +
            "d.TreeNo departtree, case when length(d.TreeNo) <= 8 then d.DepartmentName else " +
            "(select d1.DepartmentName from t_department d1 where d1.TreeNo = substr(d.TreeNo, 1, 8)) end 科室, " +
            "s.TreeNo servicetree, s.ItilServiceName 服务, i.incidenttitle 事件, i.incidentdescription 详情, i.process 处理, " +
            "i.CurrentState, uc.AccountName " +
            "from t_incident i, t_user uc, t_department d, t_itilservice s where i.CreateUserId = uc.UserID " +
            "and i.DepartmentID = d.DepartmentID and i.FinalSupportItilServiceID = s.ItilServiceID " +
            "and i.DataState = '1' and i.CurrentState < '90' and uc.AccountName = ?uid order by i.incidentno";

        private const string PARM_UID = "?uid";
        private const string PARM_STRDATE = "?strdate";

        /// <summary>
        /// Function to get a list of items within a product group
        /// </summary>
        /// <param name="productId">Product Id</param>
        /// <returns>A Generic List of ItemInfo</returns>
        public static DataTable GetItemsByProduct(string userid, string date)
        {

            // Declare array to return
            DataTable list = new DataTable();
            list.Columns.Add("编号", typeof(string));
            list.Columns.Add("时间", typeof(string));
            list.Columns.Add("departtree", typeof(string));
            list.Columns.Add("科室", typeof(string));
            list.Columns.Add("servicetree", typeof(string));
            list.Columns.Add("服务", typeof(string));
            list.Columns.Add("事件", typeof(string));
            list.Columns.Add("详情", typeof(string));
            list.Columns.Add("处理", typeof(string));

            MySqlParameter[] parms = new MySqlParameter[] {
                new MySqlParameter(PARM_UID, MySqlDbType.VarChar, 50),
                new MySqlParameter(PARM_STRDATE, MySqlDbType.String, 10)};

            //Set the parameter value
            parms[0].Value = userid;
            parms[1].Value = date;

            //Execute the query
            using (MySqlDataReader rdr = MySqlHelper.ExecuteReader(Comm.ITSMConn, SQL_GETLIST, parms))
            {

                // Scroll through the results
                while (rdr.Read())
                {
                    list.Rows.Add(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8));
                }
            }

            return list;
        }

        public IList<ITSM_Incident> GetOpenIncident(string user)
        {
            List<ITSM_Incident> incidents = new List<ITSM_Incident>();
            MySqlParameter parm = new MySqlParameter(PARM_UID, MySqlDbType.VarChar, 50);
            parm.Value = user;

            using (MySqlDataReader rdr = MySqlHelper.ExecuteReader(Comm.ITSMConn, SQL_GETOPEN, parm))
            {
                while (rdr.Read())
                {
                    ITSM_Incident incident = new ITSM_Incident(rdr.GetString(0), rdr.GetString(1), rdr.IsDBNull(2) ? "" : rdr.GetString(2),
                        rdr.IsDBNull(3) ? "" : rdr.GetString(3), rdr.IsDBNull(4) ? "" : rdr.GetString(4), rdr.IsDBNull(5) ? "" : rdr.GetString(5),
                         rdr.IsDBNull(6) ? "" : rdr.GetString(6), rdr.IsDBNull(7) ? "" : rdr.GetString(7), rdr.IsDBNull(8) ? "" : rdr.GetString(8),
                         rdr.GetString(9), rdr.GetString(10));
                    incidents.Add(incident);
                }
            }
            return incidents;
        }
    }
}
