namespace first.Admin
{
    partial class DoctorManagement
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorManagement));
            label7 = new Label();
            txt_schedule = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_contactInfo = new TextBox();
            txt_name = new TextBox();
            txt_dept = new TextBox();
            btn_add_doc = new Button();
            btn_update_doc = new Button();
            btn_delete_doc = new Button();
            dgv_doctors = new DataGridView();
            pc_prev = new PictureBox();
            pc_next = new PictureBox();
            btn_reports = new Button();
            btn_logout = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_prev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_next).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.ForeColor = Color.FromArgb(64, 116, 192);
            label7.Location = new Point(919, 514);
            label7.Name = "label7";
            label7.Size = new Size(90, 24);
            label7.TabIndex = 48;
            label7.Text = "Schedule";
            label7.Click += label7_Click;
            // 
            // txt_schedule
            // 
            txt_schedule.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_schedule.ForeColor = Color.FromArgb(64, 116, 192);
            txt_schedule.Location = new Point(1073, 509);
            txt_schedule.Name = "txt_schedule";
            txt_schedule.Size = new Size(205, 30);
            txt_schedule.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = Color.FromArgb(64, 116, 192);
            label6.Location = new Point(919, 412);
            label6.Name = "label6";
            label6.Size = new Size(119, 24);
            label6.TabIndex = 46;
            label6.Text = "Contact Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.ForeColor = Color.FromArgb(64, 116, 192);
            label5.Location = new Point(919, 295);
            label5.Name = "label5";
            label5.Size = new Size(132, 24);
            label5.TabIndex = 45;
            label5.Text = "Specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.ForeColor = Color.FromArgb(64, 116, 192);
            label4.Location = new Point(919, 186);
            label4.Name = "label4";
            label4.Size = new Size(62, 24);
            label4.TabIndex = 44;
            label4.Text = "Name";
            // 
            // txt_contactInfo
            // 
            txt_contactInfo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_contactInfo.ForeColor = Color.FromArgb(64, 116, 192);
            txt_contactInfo.Location = new Point(1073, 407);
            txt_contactInfo.Name = "txt_contactInfo";
            txt_contactInfo.Size = new Size(205, 30);
            txt_contactInfo.TabIndex = 43;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.ForeColor = Color.FromArgb(64, 116, 192);
            txt_name.Location = new Point(1073, 186);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(205, 30);
            txt_name.TabIndex = 42;
            // 
            // txt_dept
            // 
            txt_dept.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_dept.ForeColor = Color.FromArgb(64, 116, 192);
            txt_dept.Location = new Point(1073, 295);
            txt_dept.Name = "txt_dept";
            txt_dept.Size = new Size(205, 30);
            txt_dept.TabIndex = 41;
            // 
            // btn_add_doc
            // 
            btn_add_doc.BackColor = Color.FromArgb(64, 116, 192);
            btn_add_doc.Cursor = Cursors.Hand;
            btn_add_doc.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_add_doc.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_add_doc.FlatStyle = FlatStyle.Flat;
            btn_add_doc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_doc.ForeColor = Color.White;
            btn_add_doc.Location = new Point(44, 524);
            btn_add_doc.Name = "btn_add_doc";
            btn_add_doc.Size = new Size(195, 46);
            btn_add_doc.TabIndex = 38;
            btn_add_doc.Text = "Add User";
            btn_add_doc.UseVisualStyleBackColor = false;
            btn_add_doc.Click += btn_add_doc_Click;
            // 
            // btn_update_doc
            // 
            btn_update_doc.BackColor = Color.FromArgb(64, 116, 192);
            btn_update_doc.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_update_doc.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_update_doc.FlatStyle = FlatStyle.Flat;
            btn_update_doc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_doc.ForeColor = Color.White;
            btn_update_doc.Location = new Point(319, 524);
            btn_update_doc.Name = "btn_update_doc";
            btn_update_doc.Size = new Size(195, 46);
            btn_update_doc.TabIndex = 39;
            btn_update_doc.Text = "Edit User";
            btn_update_doc.UseVisualStyleBackColor = false;
            btn_update_doc.Click += btn_update_doc_Click;
            // 
            // btn_delete_doc
            // 
            btn_delete_doc.BackColor = Color.FromArgb(64, 116, 192);
            btn_delete_doc.Cursor = Cursors.Hand;
            btn_delete_doc.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_delete_doc.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_delete_doc.FlatStyle = FlatStyle.Flat;
            btn_delete_doc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_doc.ForeColor = Color.White;
            btn_delete_doc.Location = new Point(592, 524);
            btn_delete_doc.Name = "btn_delete_doc";
            btn_delete_doc.Size = new Size(195, 46);
            btn_delete_doc.TabIndex = 40;
            btn_delete_doc.Text = "Delete User";
            btn_delete_doc.UseVisualStyleBackColor = false;
            btn_delete_doc.Click += btn_delete_doc_Click;
            // 
            // dgv_doctors
            // 
            dgv_doctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_doctors.BackgroundColor = Color.White;
            dgv_doctors.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 92, 154);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_doctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_doctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 116, 192);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_doctors.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_doctors.EnableHeadersVisualStyles = false;
            dgv_doctors.Location = new Point(90, 186);
            dgv_doctors.Name = "dgv_doctors";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(46, 92, 154);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_doctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_doctors.RowHeadersWidth = 51;
            dgv_doctors.Size = new Size(631, 214);
            dgv_doctors.TabIndex = 37;
            dgv_doctors.RowHeaderMouseDoubleClick += dgv_doctors_RowHeaderMouseDoubleClick;
            // 
            // pc_prev
            // 
            pc_prev.BackColor = Color.Transparent;
            pc_prev.BackgroundImage = (Image)resources.GetObject("pc_prev.BackgroundImage");
            pc_prev.BackgroundImageLayout = ImageLayout.Zoom;
            pc_prev.Location = new Point(12, 12);
            pc_prev.Name = "pc_prev";
            pc_prev.Size = new Size(32, 27);
            pc_prev.TabIndex = 50;
            pc_prev.TabStop = false;
            pc_prev.Click += pc_prev_Click;
            // 
            // pc_next
            // 
            pc_next.BackColor = Color.Transparent;
            pc_next.BackgroundImage = (Image)resources.GetObject("pc_next.BackgroundImage");
            pc_next.BackgroundImageLayout = ImageLayout.Zoom;
            pc_next.Location = new Point(1269, 12);
            pc_next.Name = "pc_next";
            pc_next.Size = new Size(32, 27);
            pc_next.TabIndex = 49;
            pc_next.TabStop = false;
            pc_next.Click += pc_next_Click;
            // 
            // btn_reports
            // 
            btn_reports.BackColor = Color.FromArgb(64, 116, 192);
            btn_reports.FlatStyle = FlatStyle.Flat;
            btn_reports.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_reports.ForeColor = Color.White;
            btn_reports.Location = new Point(12, 775);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(240, 45);
            btn_reports.TabIndex = 52;
            btn_reports.Text = "Reports ";
            btn_reports.UseVisualStyleBackColor = false;
            btn_reports.Click += btn_reports_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(64, 116, 192);
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(1061, 775);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(240, 45);
            btn_logout.TabIndex = 51;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.ForeColor = Color.FromArgb(64, 116, 192);
            label1.Location = new Point(453, 21);
            label1.Name = "label1";
            label1.Size = new Size(376, 40);
            label1.TabIndex = 53;
            label1.Text = "Doctor Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1313, 833);
            Controls.Add(label1);
            Controls.Add(btn_reports);
            Controls.Add(btn_logout);
            Controls.Add(pc_prev);
            Controls.Add(pc_next);
            Controls.Add(label7);
            Controls.Add(txt_schedule);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_contactInfo);
            Controls.Add(txt_name);
            Controls.Add(txt_dept);
            Controls.Add(btn_add_doc);
            Controls.Add(btn_update_doc);
            Controls.Add(btn_delete_doc);
            Controls.Add(dgv_doctors);
            ForeColor = Color.FromArgb(64, 116, 192);
            Name = "DoctorManagement";
            Text = "DoctorManagement";
            Load += DoctorManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_prev).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_next).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txt_schedule;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_contactInfo;
        private TextBox txt_name;
        private TextBox txt_dept;
        private Button btn_add_doc;
        private Button btn_update_doc;
        private Button btn_delete_doc;
        private DataGridView dgv_doctors;
        private PictureBox pc_prev;
        private PictureBox pc_next;
        private Button btn_reports;
        private Button btn_logout;
        private Label label1;
    }
}