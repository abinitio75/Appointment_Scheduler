
namespace Appointment_Scheduler
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnScheduleReport = new System.Windows.Forms.Button();
            this.lblGenerateReports = new System.Windows.Forms.Label();
            this.btnPeakTimes = new System.Windows.Forms.Button();
            this.btnAppointmentTypeReport = new System.Windows.Forms.Button();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnMonthView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnWeekView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCustomerList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLabelAppointment = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(223, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(142, 101);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 28);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 42);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(298, 34);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(298, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(298, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.viewPanel);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 553);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Location = new System.Drawing.Point(6, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 325);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer2.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer2.Panel1.Controls.Add(this.btnUpdate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnScheduleReport);
            this.splitContainer2.Panel2.Controls.Add(this.lblGenerateReports);
            this.splitContainer2.Panel2.Controls.Add(this.btnPeakTimes);
            this.splitContainer2.Panel2.Controls.Add(this.btnAppointmentTypeReport);
            this.splitContainer2.Panel2.Controls.Add(this.btnExit);
            this.splitContainer2.Panel2.Controls.Add(this.btnLogOut);
            this.splitContainer2.Size = new System.Drawing.Size(301, 325);
            this.splitContainer2.SplitterDistance = 145;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnScheduleReport
            // 
            this.btnScheduleReport.BackColor = System.Drawing.SystemColors.Info;
            this.btnScheduleReport.Location = new System.Drawing.Point(12, 97);
            this.btnScheduleReport.Name = "btnScheduleReport";
            this.btnScheduleReport.Size = new System.Drawing.Size(88, 32);
            this.btnScheduleReport.TabIndex = 9;
            this.btnScheduleReport.Text = "Schedule";
            this.btnScheduleReport.UseVisualStyleBackColor = false;
            this.btnScheduleReport.Click += new System.EventHandler(this.btnScheduleReport_Click);
            // 
            // lblGenerateReports
            // 
            this.lblGenerateReports.AutoSize = true;
            this.lblGenerateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateReports.Location = new System.Drawing.Point(79, 0);
            this.lblGenerateReports.Name = "lblGenerateReports";
            this.lblGenerateReports.Size = new System.Drawing.Size(142, 18);
            this.lblGenerateReports.TabIndex = 0;
            this.lblGenerateReports.Text = "Generate Reports";
            // 
            // btnPeakTimes
            // 
            this.btnPeakTimes.BackColor = System.Drawing.SystemColors.Info;
            this.btnPeakTimes.Location = new System.Drawing.Point(182, 37);
            this.btnPeakTimes.Name = "btnPeakTimes";
            this.btnPeakTimes.Size = new System.Drawing.Size(102, 32);
            this.btnPeakTimes.TabIndex = 8;
            this.btnPeakTimes.Text = "Peak Times";
            this.btnPeakTimes.UseVisualStyleBackColor = false;
            this.btnPeakTimes.Click += new System.EventHandler(this.btnPeakTimes_Click);
            // 
            // btnAppointmentTypeReport
            // 
            this.btnAppointmentTypeReport.BackColor = System.Drawing.SystemColors.Info;
            this.btnAppointmentTypeReport.Location = new System.Drawing.Point(12, 37);
            this.btnAppointmentTypeReport.Name = "btnAppointmentTypeReport";
            this.btnAppointmentTypeReport.Size = new System.Drawing.Size(145, 32);
            this.btnAppointmentTypeReport.TabIndex = 7;
            this.btnAppointmentTypeReport.Text = "Appointment Types";
            this.btnAppointmentTypeReport.UseVisualStyleBackColor = false;
            this.btnAppointmentTypeReport.Click += new System.EventHandler(this.btnAppointmentTypeReport_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewPanel.Controls.Add(this.dgvView);
            this.viewPanel.Location = new System.Drawing.Point(3, 30);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(686, 416);
            this.viewPanel.TabIndex = 1;
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.AllowUserToResizeColumns = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvView.Location = new System.Drawing.Point(4, 4);
            this.dgvView.MultiSelect = false;
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersVisible = false;
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(679, 409);
            this.dgvView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsBtnMonthView,
            this.toolStripSeparator4,
            this.tsBtnWeekView,
            this.toolStripSeparator5,
            this.tsBtnCustomerList,
            this.toolStripSeparator3,
            this.tsLabelAppointment});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsBtnMonthView
            // 
            this.tsBtnMonthView.BackColor = System.Drawing.SystemColors.Control;
            this.tsBtnMonthView.CheckOnClick = true;
            this.tsBtnMonthView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnMonthView.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMonthView.Image")));
            this.tsBtnMonthView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMonthView.Name = "tsBtnMonthView";
            this.tsBtnMonthView.Size = new System.Drawing.Size(92, 24);
            this.tsBtnMonthView.Tag = "0";
            this.tsBtnMonthView.Text = "Month View";
            this.tsBtnMonthView.ToolTipText = "Click to view appointments for the month.";
            this.tsBtnMonthView.Click += new System.EventHandler(this.tsBtnMonthView_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsBtnWeekView
            // 
            this.tsBtnWeekView.CheckOnClick = true;
            this.tsBtnWeekView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnWeekView.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnWeekView.Image")));
            this.tsBtnWeekView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnWeekView.Name = "tsBtnWeekView";
            this.tsBtnWeekView.Size = new System.Drawing.Size(85, 24);
            this.tsBtnWeekView.Tag = "1";
            this.tsBtnWeekView.Text = "Week View";
            this.tsBtnWeekView.Click += new System.EventHandler(this.tsBtnWeekView_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsBtnCustomerList
            // 
            this.tsBtnCustomerList.CheckOnClick = true;
            this.tsBtnCustomerList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnCustomerList.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCustomerList.Image")));
            this.tsBtnCustomerList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCustomerList.Name = "tsBtnCustomerList";
            this.tsBtnCustomerList.Size = new System.Drawing.Size(102, 24);
            this.tsBtnCustomerList.Tag = "2";
            this.tsBtnCustomerList.Text = "Customer List";
            this.tsBtnCustomerList.Click += new System.EventHandler(this.tsBtnCustomerList_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsLabelAppointment
            // 
            this.tsLabelAppointment.BackColor = System.Drawing.Color.White;
            this.tsLabelAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsLabelAppointment.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.tsLabelAppointment.Name = "tsLabelAppointment";
            this.tsLabelAppointment.Size = new System.Drawing.Size(160, 24);
            this.tsLabelAppointment.Text = "Appointment Calendar";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 577);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainScreen";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsLabelAppointment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnMonthView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnWeekView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnCustomerList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnScheduleReport;
        private System.Windows.Forms.Label lblGenerateReports;
        private System.Windows.Forms.Button btnPeakTimes;
        private System.Windows.Forms.Button btnAppointmentTypeReport;
    }
}

