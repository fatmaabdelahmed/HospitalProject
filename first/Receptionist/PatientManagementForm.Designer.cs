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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            btn_qr = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_patient).BeginInit();
            SuspendLayout();
            // 
            // txt_serchpat
            // 
            txt_serchpat.Location = new Point(12, 11);
            txt_serchpat.Name = "txt_serchpat";
            txt_serchpat.Size = new Size(699, 27);
            txt_serchpat.TabIndex = 19;
            // 
            // btn_sear_pat
            // 
            btn_sear_pat.BackColor = Color.FromArgb(64, 116, 192);
            btn_sear_pat.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_sear_pat.ForeColor = Color.White;
            btn_sear_pat.Location = new Point(771, 3);
            btn_sear_pat.Name = "btn_sear_pat";
            btn_sear_pat.Size = new Size(121, 38);
            btn_sear_pat.TabIndex = 18;
            btn_sear_pat.Text = "Search";
            btn_sear_pat.UseVisualStyleBackColor = false;
            btn_sear_pat.Click += btn_sear_pat_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(64, 116, 192);
            btn_delete.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(800, 606);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(207, 50);
            btn_delete.TabIndex = 17;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(64, 116, 192);
            btn_edit.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(800, 536);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(207, 50);
            btn_edit.TabIndex = 16;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(64, 116, 192);
            btn_add.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(800, 463);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(207, 50);
            btn_add.TabIndex = 15;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // cb_gen
            // 
            cb_gen.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            cb_gen.ForeColor = Color.FromArgb(64, 116, 192);
            cb_gen.FormattingEnabled = true;
            cb_gen.Location = new Point(900, 287);
            cb_gen.Name = "cb_gen";
            cb_gen.Size = new Size(171, 26);
            cb_gen.TabIndex = 14;
            // 
            // dt_patient
            // 
            dt_patient.CustomFormat = "yyyy-MM-dd HH:mm";
            dt_patient.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            dt_patient.Format = DateTimePickerFormat.Custom;
            dt_patient.Location = new Point(900, 237);
            dt_patient.Name = "dt_patient";
            dt_patient.ShowUpDown = true;
            dt_patient.Size = new Size(171, 26);
            dt_patient.TabIndex = 13;
            // 
            // dgv_patient
            // 
            dgv_patient.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 116, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patient.EnableHeadersVisualStyles = false;
            dgv_patient.Location = new Point(12, 68);
            dgv_patient.Name = "dgv_patient";
            dgv_patient.RowHeadersWidth = 51;
            dgv_patient.Size = new Size(699, 604);
            dgv_patient.TabIndex = 10;
            dgv_patient.RowHeaderMouseDoubleClick += dgv_patient_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txt_name.ForeColor = Color.FromArgb(64, 116, 192);
            txt_name.Location = new Point(900, 86);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(171, 26);
            txt_name.TabIndex = 20;
            // 
            // txt_contact
            // 
            txt_contact.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txt_contact.ForeColor = Color.FromArgb(64, 116, 192);
            txt_contact.Location = new Point(900, 133);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(171, 26);
            txt_contact.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 116, 192);
            label1.Location = new Point(717, 88);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 22;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 116, 192);
            label2.Location = new Point(717, 135);
            label2.Name = "label2";
            label2.Size = new Size(130, 24);
            label2.TabIndex = 23;
            label2.Text = "contact info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 116, 192);
            label3.Location = new Point(717, 184);
            label3.Name = "label3";
            label3.Size = new Size(165, 24);
            label3.TabIndex = 24;
            label3.Text = "medical history";
            // 
            // txt_medical
            // 
            txt_medical.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            txt_medical.ForeColor = Color.FromArgb(64, 116, 192);
            txt_medical.Location = new Point(900, 186);
            txt_medical.Name = "txt_medical";
            txt_medical.Size = new Size(171, 26);
            txt_medical.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 116, 192);
            label4.Location = new Point(717, 237);
            label4.Name = "label4";
            label4.Size = new Size(136, 24);
            label4.TabIndex = 26;
            label4.Text = "date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 116, 192);
            label5.Location = new Point(717, 287);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 27;
            label5.Text = "gender";
            // 
            // btn_qr
            // 
            btn_qr.BackColor = Color.FromArgb(64, 116, 192);
            btn_qr.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_qr.ForeColor = Color.White;
            btn_qr.Location = new Point(800, 381);
            btn_qr.Name = "btn_qr";
            btn_qr.Size = new Size(207, 50);
            btn_qr.TabIndex = 28;
            btn_qr.Text = "QR";
            btn_qr.UseVisualStyleBackColor = false;
            btn_qr.Click += btn_qr_Click;
            // 
            // PatientManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1122, 698);
            Controls.Add(btn_qr);
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
        private Button btn_qr;
    }
}