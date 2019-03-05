namespace WorkDiary.UIL
{
    partial class F_ITSM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_SetOA = new System.Windows.Forms.Button();
            this.TB_UID = new System.Windows.Forms.TextBox();
            this.Btn_GetITSM = new System.Windows.Forms.Button();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.DGV_ITSM = new System.Windows.Forms.DataGridView();
            this.B_GetOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ITSM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_GetOpen);
            this.groupBox1.Controls.Add(this.Btn_SetOA);
            this.groupBox1.Controls.Add(this.TB_UID);
            this.groupBox1.Controls.Add(this.Btn_GetITSM);
            this.groupBox1.Controls.Add(this.DTP_Date);
            this.groupBox1.Controls.Add(this.DGV_ITSM);
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 668);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Btn_SetOA
            // 
            this.Btn_SetOA.Enabled = false;
            this.Btn_SetOA.Location = new System.Drawing.Point(865, 169);
            this.Btn_SetOA.Name = "Btn_SetOA";
            this.Btn_SetOA.Size = new System.Drawing.Size(75, 23);
            this.Btn_SetOA.TabIndex = 9;
            this.Btn_SetOA.Text = "SetOA";
            this.Btn_SetOA.UseVisualStyleBackColor = true;
            this.Btn_SetOA.Click += new System.EventHandler(this.Btn_SetOA_Click);
            // 
            // TB_UID
            // 
            this.TB_UID.Location = new System.Drawing.Point(279, 126);
            this.TB_UID.Name = "TB_UID";
            this.TB_UID.Size = new System.Drawing.Size(105, 21);
            this.TB_UID.TabIndex = 8;
            // 
            // Btn_GetITSM
            // 
            this.Btn_GetITSM.Location = new System.Drawing.Point(739, 169);
            this.Btn_GetITSM.Name = "Btn_GetITSM";
            this.Btn_GetITSM.Size = new System.Drawing.Size(75, 23);
            this.Btn_GetITSM.TabIndex = 7;
            this.Btn_GetITSM.Text = "LoadITSM";
            this.Btn_GetITSM.UseVisualStyleBackColor = true;
            this.Btn_GetITSM.Click += new System.EventHandler(this.Btn_GetITSM_Click);
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(540, 126);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(200, 21);
            this.DTP_Date.TabIndex = 6;
            // 
            // DGV_ITSM
            // 
            this.DGV_ITSM.AllowUserToAddRows = false;
            this.DGV_ITSM.AllowUserToDeleteRows = false;
            this.DGV_ITSM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ITSM.Location = new System.Drawing.Point(16, 212);
            this.DGV_ITSM.Name = "DGV_ITSM";
            this.DGV_ITSM.ReadOnly = true;
            this.DGV_ITSM.RowTemplate.Height = 23;
            this.DGV_ITSM.Size = new System.Drawing.Size(932, 330);
            this.DGV_ITSM.TabIndex = 5;
            // 
            // B_GetOpen
            // 
            this.B_GetOpen.Location = new System.Drawing.Point(411, 169);
            this.B_GetOpen.Name = "B_GetOpen";
            this.B_GetOpen.Size = new System.Drawing.Size(75, 23);
            this.B_GetOpen.TabIndex = 10;
            this.B_GetOpen.Text = "button1";
            this.B_GetOpen.UseVisualStyleBackColor = true;
            this.B_GetOpen.Click += new System.EventHandler(this.B_GetOpen_Click);
            // 
            // F_ITSM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 881);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_ITSM";
            this.Text = "F_ITSM";
            this.Load += new System.EventHandler(this.F_ITSM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ITSM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_SetOA;
        private System.Windows.Forms.TextBox TB_UID;
        private System.Windows.Forms.Button Btn_GetITSM;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.DataGridView DGV_ITSM;
        private System.Windows.Forms.Button B_GetOpen;
    }
}