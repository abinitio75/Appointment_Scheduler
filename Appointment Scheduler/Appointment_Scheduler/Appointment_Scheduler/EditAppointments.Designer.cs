
namespace Appointment_Scheduler
{
    partial class EditAppointments
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.listCustomerSelect = new System.Windows.Forms.ListBox();
            this.btnCustomerSelect = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 83);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(290, 80);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(290, 121);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 17);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(290, 159);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(56, 17);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 121);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(58, 83);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(130, 22);
            this.txtTitle.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(375, 75);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(130, 22);
            this.txtDescription.TabIndex = 9;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(375, 118);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(130, 22);
            this.txtLocation.TabIndex = 10;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(375, 159);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(85, 22);
            this.txtContact.TabIndex = 11;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(58, 121);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(105, 22);
            this.txtType.TabIndex = 12;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 159);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(38, 17);
            this.lblStart.TabIndex = 15;
            this.lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(12, 194);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(33, 17);
            this.lblEnd.TabIndex = 16;
            this.lblEnd.Text = "End";
            // 
            // listCustomerSelect
            // 
            this.listCustomerSelect.FormattingEnabled = true;
            this.listCustomerSelect.ItemHeight = 16;
            this.listCustomerSelect.Location = new System.Drawing.Point(53, 12);
            this.listCustomerSelect.Name = "listCustomerSelect";
            this.listCustomerSelect.Size = new System.Drawing.Size(185, 52);
            this.listCustomerSelect.TabIndex = 19;
            // 
            // btnCustomerSelect
            // 
            this.btnCustomerSelect.Location = new System.Drawing.Point(256, 28);
            this.btnCustomerSelect.Name = "btnCustomerSelect";
            this.btnCustomerSelect.Size = new System.Drawing.Size(133, 23);
            this.btnCustomerSelect.TabIndex = 20;
            this.btnCustomerSelect.Text = "Select Customer";
            this.btnCustomerSelect.UseVisualStyleBackColor = true;
            this.btnCustomerSelect.Click += new System.EventHandler(this.btnCustomerSelect_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(58, 157);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(209, 22);
            this.dtpStart.TabIndex = 21;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(58, 194);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(209, 22);
            this.dtpEnd.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(430, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(338, 196);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnAddAppointment.TabIndex = 24;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // EditAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 231);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnCustomerSelect);
            this.Controls.Add(this.listCustomerSelect);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "EditAppointments";
            this.Text = "EditAppointments";
            this.Load += new System.EventHandler(this.EditAppointments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.ListBox listCustomerSelect;
        private System.Windows.Forms.Button btnCustomerSelect;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddAppointment;
    }
}