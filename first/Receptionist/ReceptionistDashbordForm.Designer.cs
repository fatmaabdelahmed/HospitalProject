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
            panel1 = new Panel();
            btn_profile = new Button();
            btn_doc = new Button();
            btn_patient = new Button();
            btn_appoint = new Button();
            panel2 = new Panel();
            button5 = new Button();
            label1 = new Label();
            panel3 = new Panel();
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
            panel1.Controls.Add(btn_profile);
            panel1.Controls.Add(btn_doc);
            panel1.Controls.Add(btn_patient);
            panel1.Controls.Add(btn_appoint);
            panel1.Location = new Point(12, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 733);
            panel1.TabIndex = 0;
            // 
            // btn_profile
            // 
            btn_profile.Location = new Point(19, 230);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(160, 50);
            btn_profile.TabIndex = 3;
            btn_profile.Text = "Edit Profile";
            btn_profile.UseVisualStyleBackColor = true;
            // 
            // btn_doc
            // 
            btn_doc.Location = new Point(19, 160);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(160, 50);
            btn_doc.TabIndex = 2;
            btn_doc.Text = "Doctors";
            btn_doc.UseVisualStyleBackColor = true;
            // 
            // btn_patient
            // 
            btn_patient.Location = new Point(19, 93);
            btn_patient.Name = "btn_patient";
            btn_patient.Size = new Size(160, 50);
            btn_patient.TabIndex = 1;
            btn_patient.Text = "Patients";
            btn_patient.UseVisualStyleBackColor = true;
            // 
            // btn_appoint
            // 
            btn_appoint.Location = new Point(19, 26);
            btn_appoint.Name = "btn_appoint";
            btn_appoint.Size = new Size(160, 50);
            btn_appoint.TabIndex = 0;
            btn_appoint.Text = "Appointments";
            btn_appoint.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1289, 56);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(1102, 3);
            button5.Name = "button5";
            button5.Size = new Size(160, 50);
            button5.TabIndex = 4;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel3
            // 
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
            panel3.Location = new Point(235, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(1066, 733);
            panel3.TabIndex = 2;
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
            btn_sear.Location = new Point(799, 17);
            btn_sear.Name = "btn_sear";
            btn_sear.Size = new Size(160, 50);
            btn_sear.TabIndex = 8;
            btn_sear.Text = "Search";
            btn_sear.UseVisualStyleBackColor = true;
            btn_sear.Click += btn_sear_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(814, 620);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(160, 50);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(814, 538);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(160, 50);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(814, 471);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(160, 50);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cb_stat
            // 
            cb_stat.FormattingEnabled = true;
            cb_stat.Location = new Point(799, 248);
            cb_stat.Name = "cb_stat";
            cb_stat.Size = new Size(151, 28);
            cb_stat.TabIndex = 4;
            // 
            // dtp_app
            // 
            dtp_app.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_app.Format = DateTimePickerFormat.Custom;
            dtp_app.Location = new Point(799, 198);
            dtp_app.Name = "dtp_app";
            dtp_app.ShowUpDown = true;
            dtp_app.Size = new Size(240, 27);
            dtp_app.TabIndex = 3;
            // 
            // cb_patie
            // 
            cb_patie.FormattingEnabled = true;
            cb_patie.Location = new Point(799, 150);
            cb_patie.Name = "cb_patie";
            cb_patie.Size = new Size(151, 28);
            cb_patie.TabIndex = 2;
            // 
            // cb_doc
            // 
            cb_doc.FormattingEnabled = true;
            cb_doc.Location = new Point(799, 93);
            cb_doc.Name = "cb_doc";
            cb_doc.Size = new Size(151, 28);
            cb_doc.TabIndex = 1;
            // 
            // dgv_appo
            // 
            dgv_appo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appo.Location = new Point(18, 78);
            dgv_appo.Name = "dgv_appo";
            dgv_appo.RowHeadersWidth = 51;
            dgv_appo.Size = new Size(699, 652);
            dgv_appo.TabIndex = 0;
            dgv_appo.RowHeaderMouseDoubleClick += dgv_appo_RowHeaderMouseDoubleClick;
            // 
            // ReceptionistDashbordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 833);
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
        private Label label1;
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
    }
}