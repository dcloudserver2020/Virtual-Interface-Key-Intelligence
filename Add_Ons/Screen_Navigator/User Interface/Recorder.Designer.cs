namespace Screen_Navigator.User_Interface
{
    partial class Recorder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recorder));
            this.curXYLabel = new System.Windows.Forms.Label();
            this.L_MousePointInfo = new System.Windows.Forms.Label();
            this.B_Record = new System.Windows.Forms.Button();
            this.B_Stop = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.P_SaveRecording = new System.Windows.Forms.Panel();
            this.B_Submit = new System.Windows.Forms.Button();
            this.TB_RecordingName = new System.Windows.Forms.TextBox();
            this.L_RecordingName = new System.Windows.Forms.Label();
            this.P_RecordedInfo = new System.Windows.Forms.Panel();
            this.DGV_RecordedInfo = new System.Windows.Forms.DataGridView();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAxis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yAxis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scrool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_SaveRecording.SuspendLayout();
            this.P_RecordedInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RecordedInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // curXYLabel
            // 
            this.curXYLabel.AutoSize = true;
            this.curXYLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curXYLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.curXYLabel.Location = new System.Drawing.Point(459, 44);
            this.curXYLabel.Name = "curXYLabel";
            this.curXYLabel.Size = new System.Drawing.Size(43, 12);
            this.curXYLabel.TabIndex = 9;
            this.curXYLabel.Text = "x:0, y:0";
            // 
            // L_MousePointInfo
            // 
            this.L_MousePointInfo.AutoSize = true;
            this.L_MousePointInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MousePointInfo.ForeColor = System.Drawing.Color.DimGray;
            this.L_MousePointInfo.Location = new System.Drawing.Point(432, 21);
            this.L_MousePointInfo.Name = "L_MousePointInfo";
            this.L_MousePointInfo.Size = new System.Drawing.Size(140, 15);
            this.L_MousePointInfo.TabIndex = 10;
            this.L_MousePointInfo.Text = "Current Mouse Point";
            // 
            // B_Record
            // 
            this.B_Record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Record.BackgroundImage = global::Screen_Navigator.Properties.Resources.Record;
            this.B_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Record.FlatAppearance.BorderSize = 0;
            this.B_Record.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Record.Location = new System.Drawing.Point(-11, 11);
            this.B_Record.Name = "B_Record";
            this.B_Record.Size = new System.Drawing.Size(58, 55);
            this.B_Record.TabIndex = 5;
            this.B_Record.UseVisualStyleBackColor = false;
            this.B_Record.Click += new System.EventHandler(this.B_Record_Click);
            // 
            // B_Stop
            // 
            this.B_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Stop.BackgroundImage = global::Screen_Navigator.Properties.Resources.Stop;
            this.B_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Stop.FlatAppearance.BorderSize = 0;
            this.B_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Stop.Location = new System.Drawing.Point(44, 11);
            this.B_Stop.Name = "B_Stop";
            this.B_Stop.Size = new System.Drawing.Size(58, 55);
            this.B_Stop.TabIndex = 7;
            this.B_Stop.UseVisualStyleBackColor = false;
            this.B_Stop.Click += new System.EventHandler(this.B_Stop_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Delete.BackgroundImage = global::Screen_Navigator.Properties.Resources.Delete;
            this.B_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Delete.FlatAppearance.BorderSize = 0;
            this.B_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Delete.Location = new System.Drawing.Point(99, 11);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(58, 55);
            this.B_Delete.TabIndex = 6;
            this.B_Delete.UseVisualStyleBackColor = false;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Save
            // 
            this.B_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Save.BackgroundImage = global::Screen_Navigator.Properties.Resources.Save;
            this.B_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Save.FlatAppearance.BorderSize = 0;
            this.B_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Save.Location = new System.Drawing.Point(155, 11);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(58, 55);
            this.B_Save.TabIndex = 8;
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // P_SaveRecording
            // 
            this.P_SaveRecording.Controls.Add(this.B_Submit);
            this.P_SaveRecording.Controls.Add(this.TB_RecordingName);
            this.P_SaveRecording.Controls.Add(this.L_RecordingName);
            this.P_SaveRecording.Location = new System.Drawing.Point(150, 175);
            this.P_SaveRecording.Name = "P_SaveRecording";
            this.P_SaveRecording.Size = new System.Drawing.Size(300, 150);
            this.P_SaveRecording.TabIndex = 3;
            // 
            // B_Submit
            // 
            this.B_Submit.Location = new System.Drawing.Point(209, 108);
            this.B_Submit.Name = "B_Submit";
            this.B_Submit.Size = new System.Drawing.Size(75, 23);
            this.B_Submit.TabIndex = 2;
            this.B_Submit.Text = "Submit";
            this.B_Submit.UseVisualStyleBackColor = true;
            // 
            // TB_RecordingName
            // 
            this.TB_RecordingName.Location = new System.Drawing.Point(43, 66);
            this.TB_RecordingName.Name = "TB_RecordingName";
            this.TB_RecordingName.Size = new System.Drawing.Size(217, 20);
            this.TB_RecordingName.TabIndex = 1;
            // 
            // L_RecordingName
            // 
            this.L_RecordingName.AutoSize = true;
            this.L_RecordingName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_RecordingName.ForeColor = System.Drawing.Color.DimGray;
            this.L_RecordingName.Location = new System.Drawing.Point(25, 30);
            this.L_RecordingName.Name = "L_RecordingName";
            this.L_RecordingName.Size = new System.Drawing.Size(115, 15);
            this.L_RecordingName.TabIndex = 0;
            this.L_RecordingName.Text = "Recording Name";
            // 
            // P_RecordedInfo
            // 
            this.P_RecordedInfo.Controls.Add(this.DGV_RecordedInfo);
            this.P_RecordedInfo.Location = new System.Drawing.Point(12, 67);
            this.P_RecordedInfo.Name = "P_RecordedInfo";
            this.P_RecordedInfo.Size = new System.Drawing.Size(560, 382);
            this.P_RecordedInfo.TabIndex = 11;
            // 
            // DGV_RecordedInfo
            // 
            this.DGV_RecordedInfo.AllowUserToAddRows = false;
            this.DGV_RecordedInfo.AllowUserToDeleteRows = false;
            this.DGV_RecordedInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_RecordedInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.DGV_RecordedInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_RecordedInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_RecordedInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_RecordedInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_RecordedInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventType,
            this.KeyCode,
            this.KeyChar,
            this.xAxis,
            this.yAxis,
            this.Scrool,
            this.DelayTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_RecordedInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_RecordedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_RecordedInfo.EnableHeadersVisualStyles = false;
            this.DGV_RecordedInfo.GridColor = System.Drawing.Color.DimGray;
            this.DGV_RecordedInfo.Location = new System.Drawing.Point(0, 0);
            this.DGV_RecordedInfo.MultiSelect = false;
            this.DGV_RecordedInfo.Name = "DGV_RecordedInfo";
            this.DGV_RecordedInfo.ReadOnly = true;
            this.DGV_RecordedInfo.RowHeadersVisible = false;
            this.DGV_RecordedInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_RecordedInfo.Size = new System.Drawing.Size(560, 382);
            this.DGV_RecordedInfo.TabIndex = 25;
            // 
            // EventType
            // 
            this.EventType.HeaderText = "Event Type";
            this.EventType.Name = "EventType";
            this.EventType.ReadOnly = true;
            // 
            // KeyCode
            // 
            this.KeyCode.HeaderText = "Key Code";
            this.KeyCode.Name = "KeyCode";
            this.KeyCode.ReadOnly = true;
            // 
            // KeyChar
            // 
            this.KeyChar.HeaderText = "Key Char";
            this.KeyChar.Name = "KeyChar";
            this.KeyChar.ReadOnly = true;
            // 
            // xAxis
            // 
            this.xAxis.HeaderText = "x Axis";
            this.xAxis.Name = "xAxis";
            this.xAxis.ReadOnly = true;
            // 
            // yAxis
            // 
            this.yAxis.HeaderText = "y Axis";
            this.yAxis.Name = "yAxis";
            this.yAxis.ReadOnly = true;
            // 
            // Scrool
            // 
            this.Scrool.HeaderText = "Scrool";
            this.Scrool.Name = "Scrool";
            this.Scrool.ReadOnly = true;
            // 
            // DelayTime
            // 
            this.DelayTime.HeaderText = "Delay Time";
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.ReadOnly = true;
            // 
            // Recorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.P_RecordedInfo);
            this.Controls.Add(this.P_SaveRecording);
            this.Controls.Add(this.L_MousePointInfo);
            this.Controls.Add(this.curXYLabel);
            this.Controls.Add(this.B_Record);
            this.Controls.Add(this.B_Stop);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.B_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recorder";
            this.Text = "Recorder";
            this.Load += new System.EventHandler(this.Recorder_Load);
            this.P_SaveRecording.ResumeLayout(false);
            this.P_SaveRecording.PerformLayout();
            this.P_RecordedInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RecordedInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Record;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Stop;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Label curXYLabel;
        private System.Windows.Forms.Label L_MousePointInfo;
        private System.Windows.Forms.Panel P_SaveRecording;
        private System.Windows.Forms.Button B_Submit;
        private System.Windows.Forms.TextBox TB_RecordingName;
        private System.Windows.Forms.Label L_RecordingName;
        private System.Windows.Forms.Panel P_RecordedInfo;
        private System.Windows.Forms.DataGridView DGV_RecordedInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyChar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAxis;
        private System.Windows.Forms.DataGridViewTextBoxColumn yAxis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scrool;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTime;
    }
}