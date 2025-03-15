namespace first.Admin
{
    partial class UserManagement
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            dgv_users = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            cb_role = new ComboBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            btn_logout = new Button();
            pc_next = new PictureBox();
            pc_prev = new PictureBox();
            btn_reports = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_next).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_prev).BeginInit();
            SuspendLayout();
            // 
            // dgv_users
            // 
            dgv_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgv_users.BackgroundColor = Color.White;
            dgv_users.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(46, 92, 154);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(64, 116, 192);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_users.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_users.EnableHeadersVisualStyles = false;
            dgv_users.GridColor = Color.White;
            dgv_users.Location = new Point(217, 186);
            dgv_users.Name = "dgv_users";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(46, 92, 154);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(419, 214);
            dgv_users.TabIndex = 36;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.FromArgb(64, 116, 192);
            label3.Location = new Point(919, 410);
            label3.Name = "label3";
            label3.Size = new Size(49, 24);
            label3.TabIndex = 35;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = Color.FromArgb(64, 116, 192);
            label2.Location = new Point(919, 295);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 34;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.ForeColor = Color.FromArgb(64, 116, 192);
            label1.Location = new Point(919, 186);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 33;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(64, 116, 192);
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_add.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(44, 524);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(195, 46);
            btn_add.TabIndex = 30;
            btn_add.Text = "Add User";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(64, 116, 192);
            btn_update.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_update.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(319, 524);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(195, 46);
            btn_update.TabIndex = 31;
            btn_update.Text = "Edit User";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(64, 116, 192);
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(592, 524);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(195, 46);
            btn_delete.TabIndex = 32;
            btn_delete.Text = "Delete User";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // cb_role
            // 
            cb_role.ForeColor = Color.FromArgb(64, 116, 192);
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(1073, 406);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(205, 28);
            cb_role.TabIndex = 29;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.FromArgb(64, 116, 192);
            txt_password.Location = new Point(1073, 295);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(205, 30);
            txt_password.TabIndex = 28;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.ForeColor = Color.FromArgb(64, 116, 192);
            txt_username.Location = new Point(1073, 186);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(205, 30);
            txt_username.TabIndex = 27;
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
            btn_logout.TabIndex = 38;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // pc_next
            // 
            pc_next.BackColor = Color.Transparent;
            pc_next.BackgroundImage = (Image)resources.GetObject("pc_next.BackgroundImage");
            pc_next.BackgroundImageLayout = ImageLayout.Zoom;
            pc_next.Location = new Point(1269, 12);
            pc_next.Name = "pc_next";
            pc_next.Size = new Size(32, 27);
            pc_next.TabIndex = 40;
            pc_next.TabStop = false;
            pc_next.Click += pc_next_Click;
            // 
            // pc_prev
            // 
            pc_prev.BackColor = Color.Transparent;
            pc_prev.BackgroundImage = (Image)resources.GetObject("pc_prev.BackgroundImage");
            pc_prev.BackgroundImageLayout = ImageLayout.Zoom;
            pc_prev.Location = new Point(12, 12);
            pc_prev.Name = "pc_prev";
            pc_prev.Size = new Size(32, 27);
            pc_prev.TabIndex = 41;
            pc_prev.TabStop = false;
            pc_prev.Click += pc_prev_Click;
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
            btn_reports.TabIndex = 42;
            btn_reports.Text = "Reports ";
            btn_reports.UseVisualStyleBackColor = false;
            btn_reports.Click += btn_reports_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label4.ForeColor = Color.FromArgb(64, 116, 192);
            label4.Location = new Point(453, 21);
            label4.Name = "label4";
            label4.Size = new Size(334, 40);
            label4.TabIndex = 43;
            label4.Text = "User Management";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1313, 833);
            Controls.Add(label4);
            Controls.Add(btn_reports);
            Controls.Add(pc_prev);
            Controls.Add(pc_next);
            Controls.Add(btn_logout);
            Controls.Add(dgv_users);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(cb_role);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_next).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_prev).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_users;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox cb_role;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button btn_logout;
        private PictureBox pc_next;
        private PictureBox pc_prev;
        private Button btn_reports;
        private Label label4;
    }
}