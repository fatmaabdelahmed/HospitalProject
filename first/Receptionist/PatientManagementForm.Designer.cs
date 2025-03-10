namespace first.Receptionist
{
    partial class PatientManagementForm
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
            txt_serchpat = new TextBox();
            btn_sear_pat = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            cb_gen = new ComboBox();
            dt_patient = new DateTimePicker();
            dgv_patient = new DataGridView();
            txt_name = new TextBox();
            txt_contact = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_medical = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_patient).BeginInit();
            SuspendLayout();
            // 
            // txt_serchpat
            // 
            txt_serchpat.Location = new Point(2, 3);
            txt_serchpat.Name = "txt_serchpat";
            txt_serchpat.Size = new Size(699, 27);
            txt_serchpat.TabIndex = 19;
            // 
            // btn_sear_pat
            // 
            btn_sear_pat.Location = new Point(783, 3);
            btn_sear_pat.Name = "btn_sear_pat";
            btn_sear_pat.Size = new Size(160, 50);
            btn_sear_pat.TabIndex = 18;
            btn_sear_pat.Text = "Search";
            btn_sear_pat.UseVisualStyleBackColor = true;
            btn_sear_pat.Click += btn_sear_pat_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(798, 606);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(160, 50);
            btn_delete.TabIndex = 17;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(798, 524);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(160, 50);
            btn_edit.TabIndex = 16;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(798, 457);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(160, 50);
            btn_add.TabIndex = 15;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cb_gen
            // 
            cb_gen.FormattingEnabled = true;
            cb_gen.Location = new Point(858, 367);
            cb_gen.Name = "cb_gen";
            cb_gen.Size = new Size(151, 28);
            cb_gen.TabIndex = 14;
            // 
            // dt_patient
            // 
            dt_patient.CustomFormat = "yyyy-MM-dd HH:mm";
            dt_patient.Format = DateTimePickerFormat.Custom;
            dt_patient.Location = new Point(769, 334);
            dt_patient.Name = "dt_patient";
            dt_patient.ShowUpDown = true;
            dt_patient.Size = new Size(240, 27);
            dt_patient.TabIndex = 13;
            // 
            // dgv_patient
            // 
            dgv_patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patient.Location = new Point(2, 36);
            dgv_patient.Name = "dgv_patient";
            dgv_patient.RowHeadersWidth = 51;
            dgv_patient.Size = new Size(699, 652);
            dgv_patient.TabIndex = 10;
            dgv_patient.RowHeaderMouseDoubleClick += dgv_patient_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(900, 86);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 20;
            // 
            // txt_contact
            // 
            txt_contact.Location = new Point(900, 135);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(125, 27);
            txt_contact.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(771, 92);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 22;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(771, 138);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 23;
            label2.Text = "contact info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(771, 213);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 24;
            label3.Text = "medical history";
            // 
            // txt_medical
            // 
            txt_medical.Location = new Point(900, 213);
            txt_medical.Name = "txt_medical";
            txt_medical.Size = new Size(125, 27);
            txt_medical.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(728, 289);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 26;
            label4.Text = "date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 367);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 27;
            label5.Text = "gender";
            // 
            // PatientManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 686);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_medical);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_contact);
            Controls.Add(txt_name);
            Controls.Add(txt_serchpat);
            Controls.Add(btn_sear_pat);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(cb_gen);
            Controls.Add(dt_patient);
            Controls.Add(dgv_patient);
            Name = "PatientManagementForm";
            Text = "PatientManagementForm";
            Load += PatientManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_patient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_serchpat;
        private Button btn_sear_pat;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private ComboBox cb_gen;
        private DateTimePicker dt_patient;
        private DataGridView dgv_patient;
        private TextBox txt_name;
        private TextBox txt_contact;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_medical;
        private Label label4;
        private Label label5;
    }
}