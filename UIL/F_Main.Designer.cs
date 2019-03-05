namespace WorkDiary.UIL
{
    partial class F_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.GB_Main = new System.Windows.Forms.GroupBox();
            this.GB_Event = new System.Windows.Forms.GroupBox();
            this.B_Reset = new System.Windows.Forms.Button();
            this.Combo_EventType = new System.Windows.Forms.ComboBox();
            this.L_EventType = new System.Windows.Forms.Label();
            this.Combo_EventProject = new System.Windows.Forms.ComboBox();
            this.L_EventProject = new System.Windows.Forms.Label();
            this.GB_EventStatus = new System.Windows.Forms.GroupBox();
            this.Check_Completed = new System.Windows.Forms.CheckBox();
            this.Check_Terminated = new System.Windows.Forms.CheckBox();
            this.Check_Processing = new System.Windows.Forms.CheckBox();
            this.Check_Planed = new System.Windows.Forms.CheckBox();
            this.TB_EventContent = new System.Windows.Forms.TextBox();
            this.L_EventContent = new System.Windows.Forms.Label();
            this.TB_EventID = new System.Windows.Forms.TextBox();
            this.L_EventID = new System.Windows.Forms.Label();
            this.B_SearchEvent = new System.Windows.Forms.Button();
            this.DGV_Event = new System.Windows.Forms.DataGridView();
            this.B_SaveRecord = new System.Windows.Forms.Button();
            this.GB_EditEvent = new System.Windows.Forms.GroupBox();
            this.L_NewEventType = new System.Windows.Forms.Label();
            this.L_NewEventProject = new System.Windows.Forms.Label();
            this.LB_NewEventType = new System.Windows.Forms.ListBox();
            this.LB_NewEventProject = new System.Windows.Forms.ListBox();
            this.L_NewEventStatus = new System.Windows.Forms.Label();
            this.L_NewEventContent = new System.Windows.Forms.Label();
            this.B_NewEventSave = new System.Windows.Forms.Button();
            this.TB_NewEventType = new System.Windows.Forms.TextBox();
            this.Check_NewProject = new System.Windows.Forms.CheckBox();
            this.TB_NewEventProject = new System.Windows.Forms.TextBox();
            this.Combo_NewEventStatus = new System.Windows.Forms.ComboBox();
            this.TB_NewEventContent = new System.Windows.Forms.TextBox();
            this.DGV_Record = new System.Windows.Forms.DataGridView();
            this.NI_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMS_Notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itsmMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_Main.SuspendLayout();
            this.GB_Event.SuspendLayout();
            this.GB_EventStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Event)).BeginInit();
            this.GB_EditEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Record)).BeginInit();
            this.CMS_Notify.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Main
            // 
            this.GB_Main.Controls.Add(this.GB_Event);
            this.GB_Main.Controls.Add(this.B_SaveRecord);
            this.GB_Main.Controls.Add(this.GB_EditEvent);
            this.GB_Main.Controls.Add(this.DGV_Record);
            this.GB_Main.Location = new System.Drawing.Point(30, 20);
            this.GB_Main.Name = "GB_Main";
            this.GB_Main.Size = new System.Drawing.Size(964, 668);
            this.GB_Main.TabIndex = 0;
            this.GB_Main.TabStop = false;
            // 
            // GB_Event
            // 
            this.GB_Event.Controls.Add(this.B_Reset);
            this.GB_Event.Controls.Add(this.Combo_EventType);
            this.GB_Event.Controls.Add(this.L_EventType);
            this.GB_Event.Controls.Add(this.Combo_EventProject);
            this.GB_Event.Controls.Add(this.L_EventProject);
            this.GB_Event.Controls.Add(this.GB_EventStatus);
            this.GB_Event.Controls.Add(this.TB_EventContent);
            this.GB_Event.Controls.Add(this.L_EventContent);
            this.GB_Event.Controls.Add(this.TB_EventID);
            this.GB_Event.Controls.Add(this.L_EventID);
            this.GB_Event.Controls.Add(this.B_SearchEvent);
            this.GB_Event.Controls.Add(this.DGV_Event);
            this.GB_Event.Location = new System.Drawing.Point(6, 20);
            this.GB_Event.Name = "GB_Event";
            this.GB_Event.Size = new System.Drawing.Size(619, 275);
            this.GB_Event.TabIndex = 6;
            this.GB_Event.TabStop = false;
            this.GB_Event.Text = "事件列表";
            // 
            // B_Reset
            // 
            this.B_Reset.Location = new System.Drawing.Point(550, 44);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Size = new System.Drawing.Size(53, 23);
            this.B_Reset.TabIndex = 16;
            this.B_Reset.Text = "重置";
            this.B_Reset.UseVisualStyleBackColor = true;
            // 
            // Combo_EventType
            // 
            this.Combo_EventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_EventType.FormattingEnabled = true;
            this.Combo_EventType.Location = new System.Drawing.Point(221, 20);
            this.Combo_EventType.Name = "Combo_EventType";
            this.Combo_EventType.Size = new System.Drawing.Size(133, 20);
            this.Combo_EventType.TabIndex = 15;
            // 
            // L_EventType
            // 
            this.L_EventType.AutoSize = true;
            this.L_EventType.Location = new System.Drawing.Point(186, 23);
            this.L_EventType.Name = "L_EventType";
            this.L_EventType.Size = new System.Drawing.Size(29, 12);
            this.L_EventType.TabIndex = 14;
            this.L_EventType.Text = "类别";
            // 
            // Combo_EventProject
            // 
            this.Combo_EventProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_EventProject.FormattingEnabled = true;
            this.Combo_EventProject.Location = new System.Drawing.Point(77, 75);
            this.Combo_EventProject.Name = "Combo_EventProject";
            this.Combo_EventProject.Size = new System.Drawing.Size(121, 20);
            this.Combo_EventProject.TabIndex = 13;
            // 
            // L_EventProject
            // 
            this.L_EventProject.AutoSize = true;
            this.L_EventProject.Location = new System.Drawing.Point(18, 78);
            this.L_EventProject.Name = "L_EventProject";
            this.L_EventProject.Size = new System.Drawing.Size(53, 12);
            this.L_EventProject.TabIndex = 12;
            this.L_EventProject.Text = "所属项目";
            // 
            // GB_EventStatus
            // 
            this.GB_EventStatus.Controls.Add(this.Check_Completed);
            this.GB_EventStatus.Controls.Add(this.Check_Terminated);
            this.GB_EventStatus.Controls.Add(this.Check_Processing);
            this.GB_EventStatus.Controls.Add(this.Check_Planed);
            this.GB_EventStatus.Location = new System.Drawing.Point(360, 20);
            this.GB_EventStatus.Name = "GB_EventStatus";
            this.GB_EventStatus.Size = new System.Drawing.Size(123, 70);
            this.GB_EventStatus.TabIndex = 11;
            this.GB_EventStatus.TabStop = false;
            this.GB_EventStatus.Text = "事件状态";
            // 
            // Check_Completed
            // 
            this.Check_Completed.AutoSize = true;
            this.Check_Completed.Location = new System.Drawing.Point(60, 42);
            this.Check_Completed.Name = "Check_Completed";
            this.Check_Completed.Size = new System.Drawing.Size(48, 16);
            this.Check_Completed.TabIndex = 3;
            this.Check_Completed.Text = "完成";
            this.Check_Completed.UseVisualStyleBackColor = true;
            // 
            // Check_Terminated
            // 
            this.Check_Terminated.AutoSize = true;
            this.Check_Terminated.Location = new System.Drawing.Point(60, 20);
            this.Check_Terminated.Name = "Check_Terminated";
            this.Check_Terminated.Size = new System.Drawing.Size(48, 16);
            this.Check_Terminated.TabIndex = 2;
            this.Check_Terminated.Text = "终止";
            this.Check_Terminated.UseVisualStyleBackColor = true;
            // 
            // Check_Processing
            // 
            this.Check_Processing.AutoSize = true;
            this.Check_Processing.Checked = true;
            this.Check_Processing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_Processing.Location = new System.Drawing.Point(6, 42);
            this.Check_Processing.Name = "Check_Processing";
            this.Check_Processing.Size = new System.Drawing.Size(48, 16);
            this.Check_Processing.TabIndex = 1;
            this.Check_Processing.Text = "进行";
            this.Check_Processing.UseVisualStyleBackColor = true;
            // 
            // Check_Planed
            // 
            this.Check_Planed.AutoSize = true;
            this.Check_Planed.Checked = true;
            this.Check_Planed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_Planed.Location = new System.Drawing.Point(6, 20);
            this.Check_Planed.Name = "Check_Planed";
            this.Check_Planed.Size = new System.Drawing.Size(48, 16);
            this.Check_Planed.TabIndex = 0;
            this.Check_Planed.Text = "计划";
            this.Check_Planed.UseVisualStyleBackColor = true;
            // 
            // TB_EventContent
            // 
            this.TB_EventContent.Location = new System.Drawing.Point(77, 48);
            this.TB_EventContent.Name = "TB_EventContent";
            this.TB_EventContent.Size = new System.Drawing.Size(210, 21);
            this.TB_EventContent.TabIndex = 10;
            // 
            // L_EventContent
            // 
            this.L_EventContent.AutoSize = true;
            this.L_EventContent.Location = new System.Drawing.Point(18, 50);
            this.L_EventContent.Name = "L_EventContent";
            this.L_EventContent.Size = new System.Drawing.Size(53, 12);
            this.L_EventContent.TabIndex = 9;
            this.L_EventContent.Text = "事件内容";
            // 
            // TB_EventID
            // 
            this.TB_EventID.Location = new System.Drawing.Point(77, 20);
            this.TB_EventID.Name = "TB_EventID";
            this.TB_EventID.Size = new System.Drawing.Size(100, 21);
            this.TB_EventID.TabIndex = 8;
            // 
            // L_EventID
            // 
            this.L_EventID.AutoSize = true;
            this.L_EventID.Location = new System.Drawing.Point(18, 23);
            this.L_EventID.Name = "L_EventID";
            this.L_EventID.Size = new System.Drawing.Size(41, 12);
            this.L_EventID.TabIndex = 7;
            this.L_EventID.Text = "事件ID";
            // 
            // B_SearchEvent
            // 
            this.B_SearchEvent.Location = new System.Drawing.Point(550, 73);
            this.B_SearchEvent.Name = "B_SearchEvent";
            this.B_SearchEvent.Size = new System.Drawing.Size(53, 23);
            this.B_SearchEvent.TabIndex = 6;
            this.B_SearchEvent.Text = "检索";
            this.B_SearchEvent.UseVisualStyleBackColor = true;
            this.B_SearchEvent.Click += new System.EventHandler(this.B_SearchEvent_Click);
            // 
            // DGV_Event
            // 
            this.DGV_Event.AllowUserToAddRows = false;
            this.DGV_Event.AllowUserToDeleteRows = false;
            this.DGV_Event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Event.Location = new System.Drawing.Point(6, 97);
            this.DGV_Event.Name = "DGV_Event";
            this.DGV_Event.ReadOnly = true;
            this.DGV_Event.RowTemplate.Height = 23;
            this.DGV_Event.Size = new System.Drawing.Size(607, 172);
            this.DGV_Event.TabIndex = 4;
            this.DGV_Event.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Event_CellClick);
            // 
            // B_SaveRecord
            // 
            this.B_SaveRecord.Location = new System.Drawing.Point(792, 639);
            this.B_SaveRecord.Name = "B_SaveRecord";
            this.B_SaveRecord.Size = new System.Drawing.Size(75, 23);
            this.B_SaveRecord.TabIndex = 5;
            this.B_SaveRecord.Text = "button1";
            this.B_SaveRecord.UseVisualStyleBackColor = true;
            this.B_SaveRecord.Click += new System.EventHandler(this.B_SaveRecord_Click);
            // 
            // GB_EditEvent
            // 
            this.GB_EditEvent.Controls.Add(this.L_NewEventType);
            this.GB_EditEvent.Controls.Add(this.L_NewEventProject);
            this.GB_EditEvent.Controls.Add(this.LB_NewEventType);
            this.GB_EditEvent.Controls.Add(this.LB_NewEventProject);
            this.GB_EditEvent.Controls.Add(this.L_NewEventStatus);
            this.GB_EditEvent.Controls.Add(this.L_NewEventContent);
            this.GB_EditEvent.Controls.Add(this.B_NewEventSave);
            this.GB_EditEvent.Controls.Add(this.TB_NewEventType);
            this.GB_EditEvent.Controls.Add(this.Check_NewProject);
            this.GB_EditEvent.Controls.Add(this.TB_NewEventProject);
            this.GB_EditEvent.Controls.Add(this.Combo_NewEventStatus);
            this.GB_EditEvent.Controls.Add(this.TB_NewEventContent);
            this.GB_EditEvent.Location = new System.Drawing.Point(631, 20);
            this.GB_EditEvent.Name = "GB_EditEvent";
            this.GB_EditEvent.Size = new System.Drawing.Size(327, 275);
            this.GB_EditEvent.TabIndex = 4;
            this.GB_EditEvent.TabStop = false;
            this.GB_EditEvent.Text = "事件编辑";
            // 
            // L_NewEventType
            // 
            this.L_NewEventType.AutoSize = true;
            this.L_NewEventType.Location = new System.Drawing.Point(18, 138);
            this.L_NewEventType.Name = "L_NewEventType";
            this.L_NewEventType.Size = new System.Drawing.Size(53, 12);
            this.L_NewEventType.TabIndex = 16;
            this.L_NewEventType.Text = "事件类别";
            // 
            // L_NewEventProject
            // 
            this.L_NewEventProject.AutoSize = true;
            this.L_NewEventProject.Location = new System.Drawing.Point(18, 113);
            this.L_NewEventProject.Name = "L_NewEventProject";
            this.L_NewEventProject.Size = new System.Drawing.Size(53, 12);
            this.L_NewEventProject.TabIndex = 15;
            this.L_NewEventProject.Text = "所属项目";
            // 
            // LB_NewEventType
            // 
            this.LB_NewEventType.FormattingEnabled = true;
            this.LB_NewEventType.ItemHeight = 12;
            this.LB_NewEventType.Location = new System.Drawing.Point(191, 138);
            this.LB_NewEventType.Name = "LB_NewEventType";
            this.LB_NewEventType.Size = new System.Drawing.Size(120, 88);
            this.LB_NewEventType.TabIndex = 11;
            this.LB_NewEventType.Visible = false;
            this.LB_NewEventType.Click += new System.EventHandler(this.LB_NewEventType_Click);
            this.LB_NewEventType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LB_NewEventType_KeyDown);
            this.LB_NewEventType.Leave += new System.EventHandler(this.LB_NewEventType_Leave);
            // 
            // LB_NewEventProject
            // 
            this.LB_NewEventProject.FormattingEnabled = true;
            this.LB_NewEventProject.ItemHeight = 12;
            this.LB_NewEventProject.Location = new System.Drawing.Point(191, 108);
            this.LB_NewEventProject.Name = "LB_NewEventProject";
            this.LB_NewEventProject.Size = new System.Drawing.Size(120, 100);
            this.LB_NewEventProject.TabIndex = 6;
            this.LB_NewEventProject.Visible = false;
            this.LB_NewEventProject.Click += new System.EventHandler(this.LB_NewEventProject_Click);
            this.LB_NewEventProject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LB_NewEventProject_KeyDown);
            this.LB_NewEventProject.Leave += new System.EventHandler(this.LB_NewEventProject_Leave);
            // 
            // L_NewEventStatus
            // 
            this.L_NewEventStatus.AutoSize = true;
            this.L_NewEventStatus.Location = new System.Drawing.Point(18, 84);
            this.L_NewEventStatus.Name = "L_NewEventStatus";
            this.L_NewEventStatus.Size = new System.Drawing.Size(53, 12);
            this.L_NewEventStatus.TabIndex = 14;
            this.L_NewEventStatus.Text = "事件状态";
            // 
            // L_NewEventContent
            // 
            this.L_NewEventContent.AutoSize = true;
            this.L_NewEventContent.Location = new System.Drawing.Point(18, 57);
            this.L_NewEventContent.Name = "L_NewEventContent";
            this.L_NewEventContent.Size = new System.Drawing.Size(53, 12);
            this.L_NewEventContent.TabIndex = 13;
            this.L_NewEventContent.Text = "事件内容";
            // 
            // B_NewEventSave
            // 
            this.B_NewEventSave.Location = new System.Drawing.Point(236, 246);
            this.B_NewEventSave.Name = "B_NewEventSave";
            this.B_NewEventSave.Size = new System.Drawing.Size(75, 23);
            this.B_NewEventSave.TabIndex = 12;
            this.B_NewEventSave.Text = "保存";
            this.B_NewEventSave.UseVisualStyleBackColor = true;
            this.B_NewEventSave.Click += new System.EventHandler(this.B_NewEventSave_Click);
            // 
            // TB_NewEventType
            // 
            this.TB_NewEventType.Location = new System.Drawing.Point(77, 138);
            this.TB_NewEventType.Name = "TB_NewEventType";
            this.TB_NewEventType.Size = new System.Drawing.Size(108, 21);
            this.TB_NewEventType.TabIndex = 10;
            this.TB_NewEventType.Enter += new System.EventHandler(this.TB_NewEventType_Enter);
            this.TB_NewEventType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_NewEventType_KeyDown);
            this.TB_NewEventType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NewEventType_KeyPress);
            this.TB_NewEventType.Leave += new System.EventHandler(this.TB_NewEventType_Leave);
            // 
            // Check_NewProject
            // 
            this.Check_NewProject.AutoSize = true;
            this.Check_NewProject.Location = new System.Drawing.Point(251, 86);
            this.Check_NewProject.Name = "Check_NewProject";
            this.Check_NewProject.Size = new System.Drawing.Size(60, 16);
            this.Check_NewProject.TabIndex = 9;
            this.Check_NewProject.Text = "新项目";
            this.Check_NewProject.UseVisualStyleBackColor = true;
            this.Check_NewProject.CheckedChanged += new System.EventHandler(this.Check_NewProject_CheckedChanged);
            // 
            // TB_NewEventProject
            // 
            this.TB_NewEventProject.Location = new System.Drawing.Point(77, 108);
            this.TB_NewEventProject.Name = "TB_NewEventProject";
            this.TB_NewEventProject.Size = new System.Drawing.Size(108, 21);
            this.TB_NewEventProject.TabIndex = 5;
            this.TB_NewEventProject.Enter += new System.EventHandler(this.TB_NewEventProject_Enter);
            this.TB_NewEventProject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_NewEventProject_KeyDown);
            this.TB_NewEventProject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NewEventProject_KeyPress);
            this.TB_NewEventProject.Leave += new System.EventHandler(this.TB_NewEventProject_Leave);
            // 
            // Combo_NewEventStatus
            // 
            this.Combo_NewEventStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_NewEventStatus.FormattingEnabled = true;
            this.Combo_NewEventStatus.Items.AddRange(new object[] {
            "计划",
            "进行",
            "完成",
            "终止"});
            this.Combo_NewEventStatus.Location = new System.Drawing.Point(77, 80);
            this.Combo_NewEventStatus.Name = "Combo_NewEventStatus";
            this.Combo_NewEventStatus.Size = new System.Drawing.Size(68, 20);
            this.Combo_NewEventStatus.TabIndex = 1;
            // 
            // TB_NewEventContent
            // 
            this.TB_NewEventContent.Location = new System.Drawing.Point(77, 53);
            this.TB_NewEventContent.Name = "TB_NewEventContent";
            this.TB_NewEventContent.Size = new System.Drawing.Size(174, 21);
            this.TB_NewEventContent.TabIndex = 0;
            // 
            // DGV_Record
            // 
            this.DGV_Record.AllowUserToDeleteRows = false;
            this.DGV_Record.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Record.Location = new System.Drawing.Point(6, 330);
            this.DGV_Record.Name = "DGV_Record";
            this.DGV_Record.RowTemplate.Height = 23;
            this.DGV_Record.Size = new System.Drawing.Size(952, 281);
            this.DGV_Record.TabIndex = 1;
            this.DGV_Record.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Record_CellValueChanged);
            this.DGV_Record.Leave += new System.EventHandler(this.DGV_Record_Leave);
            // 
            // NI_Main
            // 
            this.NI_Main.ContextMenuStrip = this.CMS_Notify;
            this.NI_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("NI_Main.Icon")));
            this.NI_Main.Text = "WorkDiary";
            this.NI_Main.Visible = true;
            this.NI_Main.DoubleClick += new System.EventHandler(this.NI_Main_DoubleClick);
            // 
            // CMS_Notify
            // 
            this.CMS_Notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuItem,
            this.itsmMenuItem,
            this.exitMenuItem});
            this.CMS_Notify.Name = "CMS_Notify";
            this.CMS_Notify.Size = new System.Drawing.Size(153, 92);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // mainMenuItem
            // 
            this.mainMenuItem.Name = "mainMenuItem";
            this.mainMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mainMenuItem.Text = "工作日志";
            this.mainMenuItem.Click += new System.EventHandler(this.mainMenuItem_Click);
            // 
            // itsmMenuItem
            // 
            this.itsmMenuItem.Name = "itsmMenuItem";
            this.itsmMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itsmMenuItem.Text = "支点运维";
            this.itsmMenuItem.Click += new System.EventHandler(this.itsmMenuItem_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 822);
            this.Controls.Add(this.GB_Main);
            this.Name = "F_Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Main_FormClosing);
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.GB_Main.ResumeLayout(false);
            this.GB_Event.ResumeLayout(false);
            this.GB_Event.PerformLayout();
            this.GB_EventStatus.ResumeLayout(false);
            this.GB_EventStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Event)).EndInit();
            this.GB_EditEvent.ResumeLayout(false);
            this.GB_EditEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Record)).EndInit();
            this.CMS_Notify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Main;
        private System.Windows.Forms.DataGridView DGV_Record;
        private System.Windows.Forms.GroupBox GB_EditEvent;
        private System.Windows.Forms.ComboBox Combo_NewEventStatus;
        private System.Windows.Forms.TextBox TB_NewEventContent;
        private System.Windows.Forms.ListBox LB_NewEventProject;
        private System.Windows.Forms.TextBox TB_NewEventProject;
        private System.Windows.Forms.CheckBox Check_NewProject;
        private System.Windows.Forms.Button B_SaveRecord;
        private System.Windows.Forms.ListBox LB_NewEventType;
        private System.Windows.Forms.TextBox TB_NewEventType;
        private System.Windows.Forms.Button B_NewEventSave;
        private System.Windows.Forms.GroupBox GB_Event;
        private System.Windows.Forms.DataGridView DGV_Event;
        private System.Windows.Forms.Button B_SearchEvent;
        private System.Windows.Forms.TextBox TB_EventID;
        private System.Windows.Forms.Label L_EventID;
        private System.Windows.Forms.GroupBox GB_EventStatus;
        private System.Windows.Forms.CheckBox Check_Processing;
        private System.Windows.Forms.CheckBox Check_Planed;
        private System.Windows.Forms.TextBox TB_EventContent;
        private System.Windows.Forms.Label L_EventContent;
        private System.Windows.Forms.CheckBox Check_Completed;
        private System.Windows.Forms.CheckBox Check_Terminated;
        private System.Windows.Forms.ComboBox Combo_EventType;
        private System.Windows.Forms.Label L_EventType;
        private System.Windows.Forms.ComboBox Combo_EventProject;
        private System.Windows.Forms.Label L_EventProject;
        private System.Windows.Forms.Label L_NewEventStatus;
        private System.Windows.Forms.Label L_NewEventContent;
        private System.Windows.Forms.Label L_NewEventType;
        private System.Windows.Forms.Label L_NewEventProject;
        private System.Windows.Forms.Button B_Reset;
        private System.Windows.Forms.NotifyIcon NI_Main;
        private System.Windows.Forms.ContextMenuStrip CMS_Notify;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itsmMenuItem;
    }
}

