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
    public partial class F_ITSM : Form
    {
        private ITSMAccess data = new ITSMAccess();
        public F_ITSM()
        {
            InitializeComponent();
        }

        private void Btn_GetITSM_Click(object sender, EventArgs e)
        {
            DataTable dt = ITSMAccess.GetItemsByProduct(TB_UID.Text, DTP_Date.Value.ToString("yyyy-MM-dd"));
            DGV_ITSM.DataSource = dt;
            Btn_SetOA.Enabled = Enabled;
        }

        private void Btn_SetOA_Click(object sender, EventArgs e)
        {
            if (TB_UID.Text.Trim() == "")
                return;
            string oaname;
            int oauser = OAAccess.GetUId(TB_UID.Text, out oaname);
            if (oauser == 0)
            {
                MessageBox.Show("获取OA用户代码失败！");
                return;
            }
            for (int i = 0; i < DGV_ITSM.RowCount; i++)
            {
                OAAccess.WorkAdd(0, oauser, oaname, DTP_Date.Value.ToString("yyyyMMdd"),
                    "[" + DGV_ITSM.Rows[i].Cells[0].Value.ToString() + "]" + DGV_ITSM.Rows[i].Cells[3].Value.ToString() + DGV_ITSM.Rows[i].Cells[6].Value.ToString() + "，" + DGV_ITSM.Rows[i].Cells[8].Value.ToString() + ".",
                    "[" + DGV_ITSM.Rows[i].Cells[0].Value.ToString() + "]" + DGV_ITSM.Rows[i].Cells[3].Value.ToString() + DGV_ITSM.Rows[i].Cells[6].Value.ToString() + "，" + DGV_ITSM.Rows[i].Cells[8].Value.ToString() + ".",
                    "B-硬件维护", DGV_ITSM.Rows[i].Cells[1].Value.ToString());
            }
        }

        private void F_ITSM_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void ShowIncident(IList<ITSM_Incident> incidents)
        {
            //初始化DGV_ITSM
            DGV_ITSM.Rows.Clear();
            DGV_ITSM.ColumnCount = 11;
            DGV_ITSM.Columns[0].HeaderText = "编号";
            DGV_ITSM.Columns[1].HeaderText = "日期";
            DGV_ITSM.Columns[2].HeaderText = "科室编号";
            DGV_ITSM.Columns[3].HeaderText = "科室";
            DGV_ITSM.Columns[4].HeaderText = "类型编号";
            DGV_ITSM.Columns[5].HeaderText = "类型";
            DGV_ITSM.Columns[6].HeaderText = "事件";
            DGV_ITSM.Columns[7].HeaderText = "详情";
            DGV_ITSM.Columns[8].HeaderText = "处理";
            DGV_ITSM.Columns[9].HeaderText = "状态";
            DGV_ITSM.Columns[10].HeaderText = "工号";

            foreach (ITSM_Incident incident in incidents)
            {
                DGV_ITSM.Rows.Add(incident.IncidentNo, incident.CreateDate, incident.DepartmentTree,
                    incident.DepartmentName, incident.ItilServiceTree, incident.ItilServiceName,
                    incident.IncidentTitle, incident.IncidentDescription, incident.Process,
                    incident.CurrentState, incident.AccountName);
            }
        }

        private void B_GetOpen_Click(object sender, EventArgs e)
        {
            ShowIncident(data.GetOpenIncident(TB_UID.Text.Trim()));
            Btn_SetOA.Enabled = false;
        }
    }
}
