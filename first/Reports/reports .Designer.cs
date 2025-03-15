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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reports));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            btn_patientNo_export = new Button();
            dgv_reports = new DataGridView();
            tabPage2 = new TabPage();
            button3 = new Button();
            dgv_appointment_schedules = new DataGridView();
            tabPage3 = new TabPage();
            button4 = new Button();
            dgv_billing = new DataGridView();
            tabPage4 = new TabPage();
            button5 = new Button();
            label1 = new Label();
            com_patients = new ComboBox();
            dgv_patients = new DataGridView();
            btn_logout = new Button();
            btn_back = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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

            tabControl1.Location = new Point(-5, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1565, 730);

          //  tabControl1.Location = new Point(-1, 22);
            tabControl1.Margin = new Padding(2);
          //  tabControl1.Name = "tabControl1";
          //  tabControl1.SelectedIndex = 0;
           // tabControl1.Size = new Size(1318, 753);

            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(btn_patientNo_export);
            tabPage1.Controls.Add(dgv_reports);

            tabPage1.ForeColor = Color.FromArgb(70, 110, 182);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1549, 676);

          //  tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
          //  tabPage1.Name = "tabPage1";
            //tabPage1.Padding = new Padding(2);
            //tabPage1.Size = new Size(1310, 720);

            tabPage1.TabIndex = 0;
            tabPage1.Text = "   Number of Patients per Department   ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(664, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 723);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btn_patientNo_export
            // 

            btn_patientNo_export.BackColor = Color.FromArgb(70, 110, 182);
            btn_patientNo_export.BackgroundImageLayout = ImageLayout.Stretch;
            btn_patientNo_export.Font = new Font("Tahoma", 10.125F);
            btn_patientNo_export.ForeColor = Color.White;
            btn_patientNo_export.Location = new Point(1237, 563);
            btn_patientNo_export.Name = "btn_patientNo_export";
            btn_patientNo_export.Size = new Size(230, 73);
            btn_patientNo_export.TabIndex = 2;
            btn_patientNo_export.Text = "Export to Exel";
            btn_patientNo_export.UseVisualStyleBackColor = false;

   
            btn_patientNo_export.Margin = new Padding(2);


            btn_patientNo_export.Click += btn_patientNo_export_Click;
            // 
            // dgv_reports
            // 
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(70, 110, 182);
            dgv_reports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_reports.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(70, 110, 182);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_reports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_reports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgv_reports.EnableHeadersVisualStyles = false;
            dgv_reports.Location = new Point(42, 108);

            dgv_reports.Margin = new Padding(2);

            dgv_reports.Name = "dgv_reports";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(70, 110, 182);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_reports.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_reports.RowHeadersWidth = 82;

            dataGridViewCellStyle4.ForeColor = Color.FromArgb(70, 110, 182);
            dgv_reports.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_reports.Size = new Size(616, 402);

            dgv_reports.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dgv_appointment_schedules);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";

            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1549, 676);


            tabPage2.TabIndex = 1;
            tabPage2.Text = "   Appointment schedules     ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 

            button3.BackColor = Color.FromArgb(70, 110, 182);
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Tahoma", 10.125F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1261, 587);
            button3.Name = "button3";
            button3.Size = new Size(230, 73);
            button3.TabIndex = 3;
            button3.Text = "Export to Exel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn_appoinment_export_Click;

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
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(70, 110, 182);
            dgv_appointment_schedules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_appointment_schedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_appointment_schedules.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(70, 110, 182);
            dataGridViewCellStyle6.Font = new Font("Tahoma", 12F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_appointment_schedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_appointment_schedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(70, 110, 182);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgv_appointment_schedules.DefaultCellStyle = dataGridViewCellStyle7;
            dgv_appointment_schedules.EnableHeadersVisualStyles = false;
            dgv_appointment_schedules.GridColor = SystemColors.HighlightText;
            dgv_appointment_schedules.Location = new Point(74, 113);
            dgv_appointment_schedules.Name = "dgv_appointment_schedules";
            dgv_appointment_schedules.RowHeadersWidth = 82;
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(70, 110, 182);
            dgv_appointment_schedules.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_appointment_schedules.Size = new Size(1410, 458);

             dgv_appointment_schedules.Margin = new Padding(2);
                       dgv_appointment_schedules.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(dgv_billing);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
         tabPage3.Size = new Size(1549, 676);

            tabPage3.TabIndex = 2;
            tabPage3.Text = "   Outstanding payments    ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 

            button4.BackColor = Color.FromArgb(70, 110, 182);
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Tahoma", 10.125F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1261, 578);
            button4.Name = "button4";
            button4.Size = new Size(230, 73);
            button4.TabIndex = 3;
            button4.Text = "Export to Exel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btn_billing_Click;

            btn_billing.Margin = new Padding(2);

            // 
            // dgv_billing
            // 
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(70, 110, 182);
            dgv_billing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgv_billing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_billing.BackgroundColor = Color.White;
            dgv_billing.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(70, 110, 182);
            dataGridViewCellStyle10.Font = new Font("Tahoma", 12F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgv_billing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgv_billing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgv_billing.EnableHeadersVisualStyles = false;
            dgv_billing.Location = new Point(77, 118);

            dgv_billing.Margin = new Padding(2);

            dgv_billing.Name = "dgv_billing";
            dgv_billing.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(70, 110, 182);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgv_billing.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgv_billing.RowHeadersWidth = 82;
            dgv_billing.Size = new Size(834, 269);
            dgv_billing.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(com_patients);
            tabPage4.Controls.Add(dgv_patients);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";

            tabPage4.Size = new Size(1549, 676);

            tabPage4.TabIndex = 3;
            tabPage4.Text = "   Patient visit history     ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 

            button5.BackColor = Color.FromArgb(70, 110, 182);
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Tahoma", 10.125F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1261, 571);
            button5.Name = "button5";
            button5.Size = new Size(230, 73);
            button5.TabIndex = 4;
            button5.Text = "Export to Exel";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btn_patient_visit_history_Click;

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

            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(70, 110, 182);
            label1.Location = new Point(909, 52);
            label1.Name = "label1";
            label1.Size = new Size(130, 39);

            label1.Margin = new Padding(2, 0, 2, 0);
  

            label1.TabIndex = 2;
            label1.Text = "Patients";
            // 
            // com_patients
            // 
            com_patients.Font = new Font("Tahoma", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            com_patients.ForeColor = Color.FromArgb(70, 110, 182);
            com_patients.FormattingEnabled = true;

            com_patients.Location = new Point(1115, 52);
            com_patients.Name = "com_patients";
            com_patients.Size = new Size(405, 43);

            com_patients.Margin = new Padding(2);
   

            com_patients.TabIndex = 1;
            com_patients.SelectedIndexChanged += com_patients_SelectedIndexChanged;
            // 
            // dgv_patients
            // 
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(70, 110, 182);
            dgv_patients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            dgv_patients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_patients.BackgroundColor = Color.White;
            dgv_patients.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(70, 110, 182);
            dataGridViewCellStyle13.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgv_patients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgv_patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgv_patients.EnableHeadersVisualStyles = false;
            dgv_patients.GridColor = Color.White;
            dgv_patients.Location = new Point(117, 129);

            dgv_patients.Margin = new Padding(2);

            dgv_patients.Name = "dgv_patients";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(70, 110, 182);
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgv_patients.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgv_patients.RowHeadersWidth = 82;

            dataGridViewCellStyle15.ForeColor = Color.FromArgb(70, 110, 182);
            dgv_patients.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgv_patients.Size = new Size(1307, 418);

            dgv_patients.TabIndex = 0;
            // 
            // btn_logout
            // 

            btn_logout.BackColor = Color.FromArgb(70, 110, 182);
            btn_logout.BackgroundImageLayout = ImageLayout.Stretch;
            btn_logout.Font = new Font("Tahoma", 10.125F);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(1306, 756);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(188, 61);
            btn_logout.TabIndex = 1;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;

            btn_logout.Margin = new Padding(2);
 

            btn_logout.Click += btn_logout_Click;
            // 
            // btn_back
            // 

            btn_back.BackColor = Color.FromArgb(70, 110, 182);
            btn_back.BackgroundImageLayout = ImageLayout.Stretch;
            btn_back.Font = new Font("Tahoma", 10.125F);
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(11, 756);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(292, 61);
            btn_back.TabIndex = 2;
            btn_back.Text = "Back to Bashboard";
            btn_back.UseVisualStyleBackColor = false;

          
            btn_back.Margin = new Padding(2);



            btn_back.Click += btn_back_Click;
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            BackColor = Color.White;
            ClientSize = new Size(1552, 829);

            Controls.Add(btn_back);
            Controls.Add(btn_logout);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "reports";
            Text = " ";
            Load += reports_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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

        private Button btn_logout;
        private Button btn_back;
        private Button button3;
        private Button button4;
        private Button button5;

        private Button btn_appoinment_export;
        private Button btn_billing;
        private Button btn_patient_visit_history;
  

    }
}