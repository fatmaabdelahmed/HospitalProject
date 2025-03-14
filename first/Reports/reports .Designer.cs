namespace first.Reports
{
    partial class reports
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_patientNo_export = new Button();
            dgv_reports = new DataGridView();
            tabPage2 = new TabPage();
            btn_appoinment_export = new Button();
            dgv_appointment_schedules = new DataGridView();
            tabPage3 = new TabPage();
            btn_billing = new Button();
            dgv_billing = new DataGridView();
            tabPage4 = new TabPage();
            btn_patient_visit_history = new Button();
            label1 = new Label();
            com_patients = new ComboBox();
            dgv_patients = new DataGridView();
            btn_logout = new Button();
            btn_back = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reports).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment_schedules).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_billing).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_patients).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(-1, 22);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1318, 753);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_patientNo_export);
            tabPage1.Controls.Add(dgv_reports);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1310, 720);
            tabPage1.TabIndex = 0;
            tabPage1.Text = " Number of patients per department  ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_patientNo_export
            // 
            btn_patientNo_export.Location = new Point(663, 281);
            btn_patientNo_export.Margin = new Padding(2);
            btn_patientNo_export.Name = "btn_patientNo_export";
            btn_patientNo_export.Size = new Size(174, 43);
            btn_patientNo_export.TabIndex = 2;
            btn_patientNo_export.Text = "export to exel";
            btn_patientNo_export.UseVisualStyleBackColor = true;
            btn_patientNo_export.Click += btn_patientNo_export_Click;
            // 
            // dgv_reports
            // 
            dgv_reports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_reports.Location = new Point(16, 31);
            dgv_reports.Margin = new Padding(2);
            dgv_reports.Name = "dgv_reports";
            dgv_reports.RowHeadersWidth = 82;
            dgv_reports.Size = new Size(550, 346);
            dgv_reports.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_appoinment_export);
            tabPage2.Controls.Add(dgv_appointment_schedules);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1310, 720);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Appointment schedules  ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_appoinment_export
            // 
            btn_appoinment_export.Location = new Point(637, 350);
            btn_appoinment_export.Margin = new Padding(2);
            btn_appoinment_export.Name = "btn_appoinment_export";
            btn_appoinment_export.Size = new Size(174, 43);
            btn_appoinment_export.TabIndex = 1;
            btn_appoinment_export.Text = "export to exel";
            btn_appoinment_export.UseVisualStyleBackColor = true;
            btn_appoinment_export.Click += btn_appoinment_export_Click;
            // 
            // dgv_appointment_schedules
            // 
            dgv_appointment_schedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointment_schedules.Location = new Point(15, 30);
            dgv_appointment_schedules.Margin = new Padding(2);
            dgv_appointment_schedules.Name = "dgv_appointment_schedules";
            dgv_appointment_schedules.RowHeadersWidth = 82;
            dgv_appointment_schedules.Size = new Size(868, 296);
            dgv_appointment_schedules.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_billing);
            tabPage3.Controls.Add(dgv_billing);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1310, 720);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Outstanding payments  ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_billing
            // 
            btn_billing.Location = new Point(637, 333);
            btn_billing.Margin = new Padding(2);
            btn_billing.Name = "btn_billing";
            btn_billing.Size = new Size(174, 43);
            btn_billing.TabIndex = 1;
            btn_billing.Text = "expot to exel";
            btn_billing.UseVisualStyleBackColor = true;
            btn_billing.Click += btn_billing_Click;
            // 
            // dgv_billing
            // 
            dgv_billing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_billing.Location = new Point(26, 31);
            dgv_billing.Margin = new Padding(2);
            dgv_billing.Name = "dgv_billing";
            dgv_billing.RowHeadersWidth = 82;
            dgv_billing.Size = new Size(834, 269);
            dgv_billing.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btn_patient_visit_history);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(com_patients);
            tabPage4.Controls.Add(dgv_patients);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1310, 720);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Patient visit history  ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_patient_visit_history
            // 
            btn_patient_visit_history.Location = new Point(640, 354);
            btn_patient_visit_history.Margin = new Padding(2);
            btn_patient_visit_history.Name = "btn_patient_visit_history";
            btn_patient_visit_history.Size = new Size(174, 43);
            btn_patient_visit_history.TabIndex = 3;
            btn_patient_visit_history.Text = "expot to exel";
            btn_patient_visit_history.UseVisualStyleBackColor = true;
            btn_patient_visit_history.Click += btn_patient_visit_history_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 47);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "patients";
            // 
            // com_patients
            // 
            com_patients.FormattingEnabled = true;
            com_patients.Location = new Point(583, 42);
            com_patients.Margin = new Padding(2);
            com_patients.Name = "com_patients";
            com_patients.Size = new Size(251, 28);
            com_patients.TabIndex = 1;
            com_patients.SelectedIndexChanged += com_patients_SelectedIndexChanged;
            // 
            // dgv_patients
            // 
            dgv_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patients.Location = new Point(44, 82);
            dgv_patients.Margin = new Padding(2);
            dgv_patients.Name = "dgv_patients";
            dgv_patients.RowHeadersWidth = 82;
            dgv_patients.Size = new Size(804, 261);
            dgv_patients.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(1128, 779);
            btn_logout.Margin = new Padding(2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(174, 43);
            btn_logout.TabIndex = 4;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(11, 779);
            btn_back.Margin = new Padding(2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(174, 43);
            btn_back.TabIndex = 5;
            btn_back.Text = "Back to Dashboard";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 833);
            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "reports";
            Text = "reports";
            Load += reports_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_reports).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_appointment_schedules).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_billing).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_patients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgv_reports;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgv_appointment_schedules;
        private Label label1;
        private ComboBox com_patients;
        private DataGridView dgv_patients;
        private DataGridView dgv_billing;
        private Button btn_patientNo_export;
        private Button btn_appoinment_export;
        private Button btn_billing;
        private Button btn_patient_visit_history;
        private Button btn_logout;
        private Button btn_back;
    }
}