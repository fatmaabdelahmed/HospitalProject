namespace first.Receptionist
{
    partial class ReceptionistDashbordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionistDashbordForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_profile = new Button();
            btn_doc = new Button();
            btn_patient = new Button();
            btn_appoint = new Button();
            panel2 = new Panel();
            button1 = new Button();
            lbl_name = new Label();
            button5 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_serch = new TextBox();
            btn_sear = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            cb_stat = new ComboBox();
            dtp_app = new DateTimePicker();
            cb_patie = new ComboBox();
            cb_doc = new ComboBox();
            dgv_appo = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_profile);
            panel1.Controls.Add(btn_doc);
            panel1.Controls.Add(btn_patient);
            panel1.Controls.Add(btn_appoint);
            panel1.Location = new Point(12, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 716);
            panel1.TabIndex = 0;
            // 
            // btn_profile
            // 
            btn_profile.BackColor = Color.FromArgb(64, 116, 192);
            btn_profile.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_profile.ForeColor = Color.White;
            btn_profile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_profile.Location = new Point(15, 229);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(189, 50);
            btn_profile.TabIndex = 3;
            btn_profile.Text = "Edit Profile";
            btn_profile.UseVisualStyleBackColor = false;
            btn_profile.Click += btn_profile_Click;
            // 
            // btn_doc
            // 
            btn_doc.BackColor = Color.FromArgb(64, 116, 192);
            btn_doc.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_doc.ForeColor = Color.White;
            btn_doc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_doc.Location = new Point(15, 159);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(186, 50);
            btn_doc.TabIndex = 2;
            btn_doc.Text = "bilings";
            btn_doc.UseVisualStyleBackColor = false;
            btn_doc.Click += btn_doc_Click;
            // 
            // btn_patient
            // 
            btn_patient.BackColor = Color.FromArgb(64, 116, 192);
            btn_patient.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btn_patient.ForeColor = Color.White;
            btn_patient.ImageAlign = ContentAlignment.MiddleLeft;
            btn_patient.Location = new Point(15, 92);
            btn_patient.Name = "btn_patient";
            btn_patient.Size = new Size(186, 50);
            btn_patient.TabIndex = 1;
            btn_patient.Text = "Patients";
            btn_patient.UseVisualStyleBackColor = false;
            btn_patient.Click += btn_patient_Click;
            // 
            // btn_appoint
            // 
            btn_appoint.BackColor = Color.FromArgb(64, 116, 192);
            btn_appoint.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_appoint.ForeColor = Color.White;
            btn_appoint.ImageAlign = ContentAlignment.TopCenter;
            btn_appoint.Location = new Point(15, 17);
            btn_appoint.Name = "btn_appoint";
            btn_appoint.Size = new Size(186, 50);
            btn_appoint.TabIndex = 0;
            btn_appoint.Text = "Appointments";
            btn_appoint.UseVisualStyleBackColor = false;
            btn_appoint.Click += btn_appoint_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lbl_name);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1324, 70);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(65, 3);
            button1.Name = "button1";
            button1.Size = new Size(76, 64);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.FromArgb(64, 116, 192);
            lbl_name.Location = new Point(223, 16);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(101, 34);
            lbl_name.TabIndex = 5;
            lbl_name.Text = "label1";
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(64, 116, 192);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(1208, 8);
            button5.Name = "button5";
            button5.Size = new Size(79, 50);
            button5.TabIndex = 4;
            button5.Text = "\r\n";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txt_serch);
            panel3.Controls.Add(btn_sear);
            panel3.Controls.Add(btn_delete);
            panel3.Controls.Add(btn_edit);
            panel3.Controls.Add(btn_add);
            panel3.Controls.Add(cb_stat);
            panel3.Controls.Add(dtp_app);
            panel3.Controls.Add(cb_patie);
            panel3.Controls.Add(cb_doc);
            panel3.Controls.Add(dgv_appo);
            panel3.Location = new Point(235, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 716);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 116, 192);
            label5.Location = new Point(723, 308);
            label5.Name = "label5";
            label5.Size = new Size(74, 24);
            label5.TabIndex = 14;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 116, 192);
            label4.Location = new Point(723, 241);
            label4.Name = "label4";
            label4.Size = new Size(200, 24);
            label4.TabIndex = 13;
            label4.Text = "Appointment Date ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 116, 192);
            label3.Location = new Point(723, 171);
            label3.Name = "label3";
            label3.Size = new Size(146, 24);
            label3.TabIndex = 12;
            label3.Text = "Patient Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 116, 192);
            label2.Location = new Point(723, 104);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 11;
            label2.Text = "Dr Name\r\n";
            // 
            // txt_serch
            // 
            txt_serch.Location = new Point(18, 17);
            txt_serch.Name = "txt_serch";
            txt_serch.Size = new Size(699, 27);
            txt_serch.TabIndex = 9;
            // 
            // btn_sear
            // 
            btn_sear.BackColor = Color.FromArgb(64, 116, 192);
            btn_sear.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sear.ForeColor = Color.White;
            btn_sear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sear.Location = new Point(785, 10);
            btn_sear.Name = "btn_sear";
            btn_sear.Size = new Size(121, 38);
            btn_sear.TabIndex = 8;
            btn_sear.Text = "Search";
            btn_sear.UseVisualStyleBackColor = false;
            btn_sear.Click += btn_sear_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(64, 116, 192);
            btn_delete.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(814, 630);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(207, 50);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(64, 116, 192);
            btn_edit.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_edit.ForeColor = Color.White;
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(814, 532);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(207, 50);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(64, 116, 192);
            btn_add.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(814, 438);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(207, 50);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // cb_stat
            // 
            cb_stat.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            cb_stat.ForeColor = Color.FromArgb(64, 116, 192);
            cb_stat.FormattingEnabled = true;
            cb_stat.Location = new Point(923, 310);
            cb_stat.Name = "cb_stat";
            cb_stat.Size = new Size(160, 26);
            cb_stat.TabIndex = 4;
            // 
            // dtp_app
            // 
            dtp_app.CalendarForeColor = Color.FromArgb(43, 57, 144);
            dtp_app.CalendarTitleForeColor = Color.FromArgb(43, 57, 144);
            dtp_app.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_app.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            dtp_app.Format = DateTimePickerFormat.Custom;
            dtp_app.Location = new Point(923, 239);
            dtp_app.Name = "dtp_app";
            dtp_app.ShowUpDown = true;
            dtp_app.Size = new Size(160, 26);
            dtp_app.TabIndex = 3;
            // 
            // cb_patie
            // 
            cb_patie.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            cb_patie.ForeColor = Color.FromArgb(64, 116, 192);
            cb_patie.FormattingEnabled = true;
            cb_patie.Location = new Point(923, 171);
            cb_patie.Name = "cb_patie";
            cb_patie.Size = new Size(160, 26);
            cb_patie.TabIndex = 2;
            // 
            // cb_doc
            // 
            cb_doc.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            cb_doc.ForeColor = Color.FromArgb(64, 116, 192);
            cb_doc.FormattingEnabled = true;
            cb_doc.Location = new Point(923, 106);
            cb_doc.Name = "cb_doc";
            cb_doc.Size = new Size(160, 26);
            cb_doc.TabIndex = 1;
            // 
            // dgv_appo
            // 
            dgv_appo.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 116, 192);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_appo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_appo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_appo.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_appo.EnableHeadersVisualStyles = false;
            dgv_appo.Location = new Point(18, 78);
            dgv_appo.Name = "dgv_appo";
            dgv_appo.RowHeadersWidth = 51;
            dgv_appo.Size = new Size(699, 602);
            dgv_appo.TabIndex = 0;
            dgv_appo.RowHeaderMouseDoubleClick += dgv_appo_RowHeaderMouseDoubleClick;
            // 
            // ReceptionistDashbordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 116, 192);
            ClientSize = new Size(1348, 833);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReceptionistDashbordForm";
            Text = "ReceptionistDashbordForm";
            Load += ReceptionistDashbordForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_patient;
        private Button btn_appoint;
        private Panel panel2;
        private Panel panel3;
        private Button btn_profile;
        private Button btn_doc;
        private Button button5;
        private DataGridView dgv_appo;
        private ComboBox cb_patie;
        private ComboBox cb_doc;
        private ComboBox cb_stat;
        private DateTimePicker dtp_app;
        private Button btn_sear;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private TextBox txt_serch;
        private Label lbl_name;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}