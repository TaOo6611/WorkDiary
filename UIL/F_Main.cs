using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WorkDiary.DAL;
using WorkDiary.Model;

namespace WorkDiary.UIL
{
    public partial class F_Main : Form
    {
        private DBAccess data = new DBAccess();
        private bool recordchangeflag = false;

        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            FillComboEventType();
            FillComboEventProject();
            WindowState = FormWindowState.Maximized;
            ShowEvent();
        }

        private void FillComboEventType()
        {
            string stri;
            DataTable dt;
            stri = "select event_type_code || '||' || event_type from wd_event_type t ORDER BY event_type_code";
            dt = DAL.Comm.GetData(DAL.Comm.DBConn, stri);
            Combo_EventType.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                Combo_EventType.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void FillComboEventProject()
        {
            string stri;
            DataTable dt;
            stri = "select project_id || '||' || project_name from wd_project t ORDER BY project_name";
            dt = DAL.Comm.GetData(DAL.Comm.DBConn, stri);
            Combo_EventProject.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                Combo_EventProject.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void ShowEvent()
        {
            string sqlstr = "1 = 1";
            if (TB_EventID.Text.Trim().Length > 1)
            {
                sqlstr = sqlstr + " AND event_id LIKE '" + TB_EventID.Text.Trim() + "%'";
            }
            if (Combo_EventType.Text.Length > 1)
            {
                sqlstr = sqlstr + " AND event_type LIKE '" + Combo_EventType.Text.Substring(0, Combo_EventType.Text.IndexOf("||")) + "%'";
            }
            if (TB_EventContent.Text.Trim().Length > 1)
            {
                sqlstr = sqlstr + " AND event_content LIKE '%" + TB_EventContent.Text.Trim() + "%'";
            }
            if (Combo_EventProject.Text.Length > 1)
            {
                sqlstr = sqlstr + " AND project = '" + Combo_EventProject.Text.Substring(0, Combo_EventProject.Text.IndexOf("||")) + "'";
            }
            if(Check_Planed.Checked||Check_Processing.Checked||Check_Terminated.Checked||Check_Completed.Checked)
            {
                string str1 = "1 = 2";
                if (Check_Planed.Checked)
                    str1 = str1 + " OR event_status = '计划'";
                if (Check_Processing.Checked)
                    str1 = str1 + " OR event_status = '进行'";
                if (Check_Terminated.Checked)
                    str1 = str1 + " OR event_status = '终止'";
                if (Check_Completed.Checked)
                    str1 = str1 + " OR event_status = '完成'";
                sqlstr = sqlstr + " AND (" + str1 + ")";
            }
            //data.GetEvent(sqlstr);

            //初始化DGV_Event
            DGV_Event.Rows.Clear();
            DGV_Event.ColumnCount = 5;
            DGV_Event.Columns[0].HeaderText = "编号";
            DGV_Event.Columns[1].HeaderText = "内容";
            DGV_Event.Columns[2].HeaderText = "状态";
            DGV_Event.Columns[3].HeaderText = "项目";
            DGV_Event.Columns[4].HeaderText = "类别";

            //DGV_Event.Columns[2].Width = 100;

            foreach (EventInfo eventinfo in data.GetEvent(sqlstr))
            {
                DGV_Event.Rows.Add(eventinfo.eventid, eventinfo.eventcontent, eventinfo.eventstatus, 
                    eventinfo.eventproject, eventinfo.eventtype);
            }
        }

        //private void ShowEvent(EventInfo theevent)
        //{
        //    //初始化DGV_Event
        //    DGV_Event.Rows.Clear();
        //    DGV_Event.ColumnCount = 5;
        //    DGV_Event.Columns[0].HeaderText = "编号";
        //    DGV_Event.Columns[1].HeaderText = "内容";
        //    DGV_Event.Columns[2].HeaderText = "状态";
        //    DGV_Event.Columns[3].HeaderText = "项目";
        //    DGV_Event.Columns[4].HeaderText = "类别";

        //    //DGV_Event.Columns[2].Width = 100;

        //    DGV_Event.Rows.Add(theevent.eventid, theevent.eventcontent, theevent.eventstatus, 
        //        theevent.eventproject, theevent.eventtype);
            
        //}

        private void B_NewEventSave_Click(object sender, EventArgs e)
        {
            if(TB_NewEventContent.Text.Trim().Length<1)
            {
                MessageBox.Show("请输入事件内容！");
                TB_NewEventContent.Focus();
                return;
            }
            if (Combo_NewEventStatus.Text == "")
            {
                MessageBox.Show("请为新事件选择状态！");
                Combo_NewEventStatus.Focus();
                return;
            }
            if (Check_NewProject.Checked == true)
            {
                ProjectInfo proj = new ProjectInfo(data.GetNewProjectID(), TB_NewEventProject.Text.Trim(),
                    Comm.GetFirstPY(TB_NewEventProject.Text.Trim()), null, null, "立项");
                data.SaveNewProject(proj);
                TB_NewEventProject.Text = proj.projectid + "||" + proj.projectname;
            }
            EventInfo newEvent = new EventInfo(data.GetNewEventID(), TB_NewEventContent.Text.Trim(),
                Combo_NewEventStatus.Text, TB_NewEventType.Text.Trim().Substring(0, TB_NewEventType.Text.Trim().IndexOf("||")));
            if (TB_NewEventProject.Text.Trim().Length>1)
            {
                newEvent.eventproject = TB_NewEventProject.Text.Trim().Substring(0, TB_NewEventProject.Text.Trim().IndexOf("||"));
            }
            data.SaveNewEvent(newEvent);
            TB_EventID.Text = newEvent.eventid;
            Combo_EventType.Text = "";
            TB_EventContent.Text = "";
            Combo_EventProject.Text = "";
            Check_Planed.Checked = false;
            Check_Processing.Checked = false;
            Check_Terminated.Checked = false;
            Check_Completed.Checked = false;
            ShowEvent();
            TB_NewEventContent.Text = "";
            TB_NewEventProject.Text = "";
            Check_NewProject.Checked = false;
            TB_NewEventType.Text = "";
        }

        private void TB_NewEventProject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Check_NewProject.Checked == false)
            {
                string stri;
                //OracleParameter[] para;
                DataTable dt;
                if (TB_NewEventProject.Text.Trim().Length >= 1)
                {
                    stri = "select project_id || '||' || project_name from wd_project t where project_name_py like '%" +
                        TB_NewEventProject.Text.Trim().ToUpper() + "%' ORDER BY project_name";
                }
                else
                {
                    stri = "select project_id || '||' || project_name from wd_project t ORDER BY project_name";
                }
                //para = new OracleParameter[1];
                //para[0] = new OracleParameter("INPUT", '%' + TB_Dept.Text.Trim().ToUpper() + '%');
                dt = DAL.Comm.GetData(DAL.Comm.DBConn, stri);
                LB_NewEventProject.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                    LB_NewEventProject.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                //if (LB_Dept.Items.Count == 1)
                //{
                //    LB_Dept.SelectedIndex = 0;
                //    DeptClick();
                //    e.Handled = true;
            }
        }

        private void TB_NewEventProject_KeyDown(object sender, KeyEventArgs e)
        {
            if (Check_NewProject.Checked == false)
                if (e.KeyCode == Keys.Down && e.Shift != true)
                    LB_NewEventProject.Focus();
        }

        private void TB_NewEventProject_Leave(object sender, EventArgs e)
        {
            if (!TB_NewEventProject.Focused && !LB_NewEventProject.Focused)
            {
                LB_NewEventProject.Visible = false;
            }
        }

        private void LB_NewEventProject_Leave(object sender, EventArgs e)
        {
            if (!TB_NewEventProject.Focused && !LB_NewEventProject.Focused)
            {
                LB_NewEventProject.Visible = false;
            }
        }

        private void TB_NewEventProject_Enter(object sender, EventArgs e)
        {
            if (Check_NewProject.Checked == false)
                LB_NewEventProject.Visible = true;
        }

        private void LB_NewEventProject_Click(object sender, EventArgs e)
        {
            try
            {
                TB_NewEventProject.Text = LB_NewEventProject.SelectedItem.ToString();
            }
            catch
            { }
        }

        private void LB_NewEventProject_KeyDown(object sender, KeyEventArgs e)
        {
            if (Check_NewProject.Checked == false)
                if (e.KeyCode == Keys.Enter)
                    try
                    {
                        TB_NewEventProject.Text = LB_NewEventProject.SelectedItem.ToString();
                    }
                    catch
                    { }
        }

        private void TB_NewEventType_Enter(object sender, EventArgs e)
        {
            LB_NewEventType.Visible = true;
        }

        private void TB_NewEventType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && e.Shift != true)
                LB_NewEventType.Focus();
        }

        private void TB_NewEventType_KeyPress(object sender, KeyPressEventArgs e)
        {
            string stri;
            DataTable dt;
            if (TB_NewEventType.Text.Trim().Length >= 1)
            {
                stri = "select event_type_code || '||' || event_type from wd_event_type t where event_type_py like '%" +
                    TB_NewEventType.Text.Trim().ToUpper() + "%' ORDER BY event_type_code";
            }
            else
            {
                stri = "select event_type_code || '||' || event_type from wd_event_type t ORDER BY event_type_code";
            }
            dt = DAL.Comm.GetData(DAL.Comm.DBConn, stri);
            LB_NewEventType.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                LB_NewEventType.Items.Add(dt.Rows[i].ItemArray[0].ToString());
        }

        private void TB_NewEventType_Leave(object sender, EventArgs e)
        {
            if (!TB_NewEventType.Focused && !LB_NewEventType.Focused)
            {
                LB_NewEventType.Visible = false;
            }
        }

        private void LB_NewEventType_Click(object sender, EventArgs e)
        {
            try
            {
                TB_NewEventType.Text = LB_NewEventType.SelectedItem.ToString();
            }
            catch
            { }
        }

        private void LB_NewEventType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                try
                {
                    TB_NewEventType.Text = LB_NewEventType.SelectedItem.ToString();
                }
                catch
                { }
        }

        private void LB_NewEventType_Leave(object sender, EventArgs e)
        {
            if (!TB_NewEventType.Focused && !LB_NewEventType.Focused)
            {
                LB_NewEventType.Visible = false;
            }
        }

        private void Check_NewProject_CheckedChanged(object sender, EventArgs e)
        {
            LB_NewEventProject.Visible = false;
        }

        private void DGV_Event_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ShowRecord(data.GetRecordByEvent(DGV_Event.Rows[e.RowIndex].Cells[0].Value.ToString()));
            ShowRecord(DGV_Event.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void ShowRecord(string eid)
        {
            DGV_Record.Tag = eid;
            IList<RecordInfo> records = data.GetRecordByEvent(DGV_Record.Tag.ToString());

            //初始化DGV_Record
            DGV_Record.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DGV_Record.Rows.Clear();
            DGV_Record.ColumnCount = 4;
            DGV_Record.Columns[0].HeaderText = "编号";
            DGV_Record.Columns[0].ReadOnly = true;
            DGV_Record.Columns[1].HeaderText = "事件";
            DGV_Record.Columns[1].ReadOnly = true;
            DGV_Record.Columns[2].HeaderText = "日期";
            DGV_Record.Columns[2].ReadOnly = true;
            DGV_Record.Columns[3].HeaderText = "内容";

            //DGV_Event.Columns[2].Width = 100;

            foreach (RecordInfo record in records)
            {
                DGV_Record.Rows.Add(record.recordid, record.eventid, record.record_date, record.record_content);
            }
            recordchangeflag = false;
        }

        private void DGV_Record_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            recordchangeflag = true;
        }

        private void DGV_Record_Leave(object sender, EventArgs e)
        {
            //    if (recordchangeflag)
            //    {
            //        if (MessageBox.Show("数据已改变，是否保存？", "记录修改", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            foreach (DataGridViewRow row in DGV_Record.Rows)
            //            {
            //                if (row.IsNewRow == false)
            //                {
            //                    if (row.Cells[0].Value == null)
            //                    {
            //                        RecordInfo nrecord = new RecordInfo(data.GetNewRecordID(), DGV_Record.Tag.ToString(), row.Cells[3].Value.ToString().Trim());
            //                        data.SaveNewRecord(nrecord);
            //                    }
            //                    else
            //                    {
            //                        RecordInfo nrecord = new RecordInfo(row.Cells[0].Value.ToString().Trim(), row.Cells[1].Value.ToString().Trim(),
            //                            row.Cells[2].Value.ToString().Trim(), row.Cells[3].Value.ToString().Trim());
            //                        data.UpdateRecord(nrecord);
            //                    }
            //                }
            //            }
            //                //SaveRecords();
            //        }

            //    }
            //    ShowRecord(DGV_Record.Tag.ToString());
        }

    private void B_SaveRecord_Click(object sender, EventArgs e)
        {
            if (recordchangeflag)
            {

                foreach (DataGridViewRow row in DGV_Record.Rows)
                {
                    if (row.IsNewRow == false)
                    {
                        if (row.Cells[0].Value == null)
                        {
                            RecordInfo nrecord = new RecordInfo(data.GetNewRecordID(), DGV_Record.Tag.ToString(), row.Cells[3].Value.ToString().Trim());
                            data.SaveNewRecord(nrecord);
                        }
                        else
                        {
                            RecordInfo nrecord = new RecordInfo(row.Cells[0].Value.ToString().Trim(), row.Cells[1].Value.ToString().Trim(),
                                row.Cells[2].Value.ToString().Trim(), row.Cells[3].Value.ToString().Trim());
                            data.UpdateRecord(nrecord);
                        }
                    }
                }


            }
            ShowRecord(DGV_Record.Tag.ToString());
        }

        private void B_SearchEvent_Click(object sender, EventArgs e)
        {
            ShowEvent();
        }

        private void F_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            e.Cancel = true;
        }

        private void NI_Main_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = true;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                ShowInTaskbar = false;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            NI_Main.Dispose();
            Environment.Exit(0);
        }

        private void mainMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = true;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                ShowInTaskbar = false;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void itsmMenuItem_Click(object sender, EventArgs e)
        {
            F_ITSM frm = new F_ITSM();
            frm.Show();
        }



        //private IList<EventInfo> GetEvent()
        //{
        //    string sqlstr = "1 = 1";
        //    if (TB_EventID.Text.Trim().Length>1)
        //    {
        //        sqlstr = sqlstr + " AND event_id LIKE '" + TB_EventID.Text.Trim() + "%'";
        //    }
        //    if (Combo_EventType.Text.Length > 1)
        //    {
        //        sqlstr = sqlstr + " AND event_type = '" + Combo_EventType.Text.Substring(0, Combo_EventType.Text.IndexOf("||")) + "'";
        //    }
        //    if (TB_EventContent.Text.Trim().Length > 1)
        //    {
        //        sqlstr = sqlstr + " AND event_content LIKE '%" + TB_EventContent.Text.Trim() + "%'";
        //    }
        //    if (Combo_EventProject.Text.Length > 1)
        //    {
        //        sqlstr = sqlstr + " AND project = '" + Combo_EventProject.Text.Substring(0, Combo_EventProject.Text.IndexOf("||")) + "'";
        //    }
        //    return data.GetEvent(sqlstr);
        //}

        //private void SaveRecords()
        //{
        //    IList<RecordInfo> newrecords = new List<RecordInfo>();
        //    foreach (DataGridViewRow row in DGV_Record.Rows)
        //    {
        //        RecordInfo nrecord = new RecordInfo(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(),
        //            row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
        //        newrecords.Add(nrecord);
        //    }
        //    data.SaveRecords(newrecords, DGV_Record.Tag.ToString());
        //}
    }
}
