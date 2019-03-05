using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using WorkDiary.OracleUtility;
using WorkDiary.Model;

namespace WorkDiary.DAL
{
    public class DBAccess
    {
        //public IList<EventInfo> GetEventActive()
        //{
        //    List<EventInfo> events = new List<EventInfo>();
        //    string sqlstr = "SELECT Event_ID, Event_Content, Event_Status, Project, Event_type FROM wd_Event WHERE Event_Status IN ('计划', '进行')";

        //    using (OracleDataReader rdr = OracleHelper.ExecuteReader(Comm.DBConn, CommandType.Text, sqlstr))
        //    {
        //        while (rdr.Read())
        //        {
        //            EventInfo eventinfo = new EventInfo(rdr.GetString(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1), rdr.GetString(2),
        //                rdr.IsDBNull(3) ? "" : rdr.GetString(3), rdr.IsDBNull(4) ? "" : rdr.GetString(4));
        //            events.Add(eventinfo);
        //        }
        //    }
        //    return events;
        //}

        //public IList<EventInfo> GetEvent(long eventid, string eventcontent, string eventstatus, long eventproject, string eventtype)
        //{
        //    List<EventInfo> events = new List<EventInfo>();
        //    string sqlstr = "SELECT CStr([id]), [dbms], [conn], [sql], [val], [alm], [memo] FROM dbinfo";

        //    using (OracleDataReader rdr = OracleHelper.ExecuteReader(Comm.DBConn, CommandType.Text, sqlstr))
        //    {
        //        while (rdr.Read())
        //        {
        //            EventInfo eventinfo = new EventInfo();
        //            events.Add(eventinfo);
        //        }
        //    }
        //    return events;
        //}

        public IList<EventInfo> GetEvent(string sql)
        {
            List<EventInfo> events = new List<EventInfo>();
            string sqlstr = "SELECT Event_ID, Event_Content, Event_Status, Project, Event_type FROM wd_Event WHERE " + sql;

            using (OracleDataReader rdr = OracleHelper.ExecuteReader(Comm.DBConn, CommandType.Text, sqlstr))
            {
                while (rdr.Read())
                {
                    EventInfo eventinfo = new EventInfo(rdr.GetString(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1), rdr.GetString(2),
                        rdr.IsDBNull(3) ? "" : rdr.GetString(3), rdr.IsDBNull(4) ? "" : rdr.GetString(4));
                    events.Add(eventinfo);
                }
            }
            return events;
        }

        public string GetNewProjectID()
        {
            string projectID = string.Empty;
            string sqlstr = "SELECT to_char(wd_project_id_seq.nextval) FROM dual";

            using (OracleDataReader rdr = OracleHelper.ExecuteReader(Comm.DBConn, CommandType.Text, sqlstr))
            {
                if (rdr.Read())
                {
                    string s = "0000000" + rdr.GetString(0);
                    projectID = 'P' + s.Substring(s.Length - 7, 7);
                }
            }
            return projectID;
        }

        public string GetNewEventID()
        {
            string EventID = string.Empty;
            string sqlstr = "SELECT to_char(wd_event_id_seq.nextval), to_char(sysdate, 'yyyymmdd') FROM dual";

            using (OracleDataReader rdr = OracleHelper.ExecuteReader(Comm.DBConn, CommandType.Text, sqlstr))
            {
                if (rdr.Read())
                {
                    string s = "0000" + rdr.GetString(0);
                    EventID = rdr.GetString(1) + s.Substring(s.Length - 4, 4);
                }
            }
            return EventID;
        }

        public string GetNewRecordID()
        {
            string RecordID = string.Empty;
            string sqlstr = "SELECT to_char(wd_record_id_seq.nextval), to_char(sysdate, 'yyyymmdd') FROM dual";

            using (OracleDataReader rdr = OracleHelper.ExecuteReader(Comm.DBConn, CommandType.Text, sqlstr))
            {
                if (rdr.Read())
                {
                    string s = "0000" + rdr.GetString(0);
                    RecordID = rdr.GetString(1) + s.Substring(s.Length - 4, 4);
                }
            }
            return RecordID;
        }

        public void SaveNewProject(ProjectInfo p)
        {
            string sqlstr = "INSERT INTO wd_project VALUES(:pid, :pname, :ppy, :pdesc, :pleader, :pstatus)";
            //Create a parameter
            OracleParameter[] parm = new OracleParameter[]{
                new OracleParameter(":pid", OracleDbType.Varchar2, 8),
                new OracleParameter(":pname", OracleDbType.Varchar2, 64),
                new OracleParameter(":ppy", OracleDbType.Varchar2, 64),
                new OracleParameter(":pdesc", OracleDbType.Varchar2, 128),
                new OracleParameter(":pleader", OracleDbType.Varchar2, 8),
                new OracleParameter(":pstatus", OracleDbType.Varchar2, 8)
            };
            //Bind the parameter
            parm[0].Value = p.projectid;
            parm[1].Value = p.projectname;
            parm[2].Value = p.projectnamepy;
            parm[3].Value = p.projectdesc;
            parm[4].Value = p.projectleader;
            parm[5].Value = p.projectstatus;


            OracleHelper.ExecuteNonQuery(Comm.DBConn, CommandType.Text, sqlstr, parm);

        }

        public void SaveNewEvent(EventInfo e)
        {
            string sqlstr = "INSERT INTO wd_event VALUES(:eid, :econtent, :estatus, :eproject, :etype)";
            //Create a parameter
            OracleParameter[] parm = new OracleParameter[]{
                new OracleParameter(":eid", OracleDbType.Varchar2, 16),
                new OracleParameter(":econtent", OracleDbType.Varchar2, 128),
                new OracleParameter(":estatus", OracleDbType.Varchar2, 8),
                new OracleParameter(":eproject", OracleDbType.Varchar2, 8),
                new OracleParameter(":etype", OracleDbType.Varchar2, 8)
            };
            //Bind the parameter
            parm[0].Value = e.eventid;
            parm[1].Value = e.eventcontent;
            parm[2].Value = e.eventstatus;
            parm[3].Value = e.eventproject;
            parm[4].Value = e.eventtype;

            OracleHelper.ExecuteNonQuery(Comm.DBConn, CommandType.Text, sqlstr, parm);

        }

        public IList<RecordInfo> GetRecordByEvent(string eventid)
        {
            List<RecordInfo> records = new List<RecordInfo>();
            string sqlstr = "select record_id, event, to_char(record_date, 'yyyymmddhh24miss'), record_content from wd_record where event = '" + eventid + "'";

            using (OracleDataReader rdr = OracleHelper.ExecuteReader(Comm.DBConn, CommandType.Text, sqlstr))
            {
                while (rdr.Read())
                {
                    RecordInfo recordinfo = new RecordInfo(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2),
                        rdr.IsDBNull(3) ? "" : rdr.GetString(3));
                    records.Add(recordinfo);
                }
            }
            return records;
        }

        //public void SaveRecords(IList<RecordInfo> rs, string eid)
        //{
        //    foreach (RecordInfo r in rs)
        //    {
        //        if (r.recordid.Length<1)
        //        {
        //            SaveNewRecord(r, eid);
        //        }
        //        else
        //        {
        //            UpdateRecord(r);
        //        }
        //    }
        //}

        public void SaveNewRecord(RecordInfo r)
        {

            string sqlstr = "INSERT INTO wd_record(record_id, event, record_content) VALUES(:rid, :eid, :rcontent)";
            //Create a parameter
            OracleParameter[] parm = new OracleParameter[]{
                new OracleParameter(":rid", OracleDbType.Varchar2, 16),
                new OracleParameter(":eid", OracleDbType.Varchar2, 16),
                new OracleParameter(":rcontent", OracleDbType.Varchar2, 128)
            };
            //Bind the parameter
            parm[0].Value = r.recordid;
            parm[1].Value = r.eventid;
            parm[2].Value = r.record_content;

            OracleHelper.ExecuteNonQuery(Comm.DBConn, CommandType.Text, sqlstr, parm);
        }

        //public void SaveNewRecord(RecordInfo r, string eid)
        //{

        //    string sqlstr = "INSERT INTO wd_record(record_id, event, record_content) VALUES(:rid, :eid, :rdate, :rcontent)";
        //    //Create a parameter
        //    OracleParameter[] parm = new OracleParameter[]{
        //        new OracleParameter(":rid", OracleDbType.Varchar2, 16),
        //        new OracleParameter(":eid", OracleDbType.Varchar2, 16),
        //        new OracleParameter(":rcontent", OracleDbType.Varchar2, 128)
        //    };
        //    //Bind the parameter
        //    parm[0].Value = GetNewRecordID();
        //    parm[1].Value = eid;
        //    parm[2].Value = r.record_content;

        //    OracleHelper.ExecuteNonQuery(Comm.DBConn, CommandType.Text, sqlstr, parm);
        //}

        public void UpdateRecord(RecordInfo r)
        {

            string sqlstr = "UPDATE wd_record SET record_content = :rcontent WHERE record_id = :rid";
            //Create a parameter
            OracleParameter[] parm = new OracleParameter[]{
                new OracleParameter(":rcontent", OracleDbType.Varchar2, 128),
                new OracleParameter(":rid", OracleDbType.Varchar2, 16)
            };
            //Bind the parameter
            parm[0].Value = r.record_content;
            parm[1].Value = r.recordid;

            OracleHelper.ExecuteNonQuery(Comm.DBConn, CommandType.Text, sqlstr, parm);
        }
    }
}
