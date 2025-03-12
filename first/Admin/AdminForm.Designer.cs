namespace first.Admin
{
    partial class AdminForm
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
            tabPage1 = new TabPage();
            btn_logout = new Button();
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
            tabControl = new TabControl();
            tabPage2 = new TabPage();
            btn_logout2 = new Button();
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label7 = new Label();
            txt_schedule = new TextBox();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            tabControl.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).BeginInit();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_logout);
            tabPage1.Controls.Add(dgv_users);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btn_add);
            tabPage1.Controls.Add(btn_update);
            tabPage1.Controls.Add(btn_delete);
            tabPage1.Controls.Add(cb_role);
            tabPage1.Controls.Add(txt_password);
            tabPage1.Controls.Add(txt_username);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.CornflowerBlue;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(803, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User Management";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(664, 360);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(120, 37);
            btn_logout.TabIndex = 27;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // dgv_users
            // 
            dgv_users.BackgroundColor = Color.White;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.GridColor = Color.White;
            dgv_users.Location = new Point(-4, 0);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(807, 214);
            dgv_users.TabIndex = 26;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(554, 277);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 25;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(275, 277);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 24;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(8, 277);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 23;
            label1.Text = "User Name";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.LightGray;
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_add.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(8, 359);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(120, 37);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add User";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.DarkGray;
            btn_update.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_update.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(134, 359);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(120, 37);
            btn_update.TabIndex = 21;
            btn_update.Text = "Edit User";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DimGray;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(260, 359);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(120, 37);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Delete User";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(633, 274);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(151, 28);
            cb_role.TabIndex = 19;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(379, 272);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(148, 30);
            txt_password.TabIndex = 18;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(108, 272);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(148, 30);
            txt_username.TabIndex = 17;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(-5, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(811, 453);
            tabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txt_schedule);
            tabPage2.Controls.Add(btn_logout2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txt_contactInfo);
            tabPage2.Controls.Add(txt_name);
            tabPage2.Controls.Add(txt_dept);
            tabPage2.Controls.Add(btn_add_doc);
            tabPage2.Controls.Add(btn_update_doc);
            tabPage2.Controls.Add(btn_delete_doc);
            tabPage2.Controls.Add(dgv_doctors);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(803, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Doctor Management";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_logout2
            // 
            btn_logout2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_logout2.Location = new Point(669, 371);
            btn_logout2.Name = "btn_logout2";
            btn_logout2.Size = new Size(120, 37);
            btn_logout2.TabIndex = 34;
            btn_logout2.Text = "Log out";
            btn_logout2.UseVisualStyleBackColor = true;
            btn_logout2.Click += btn_logout2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(450, 238);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 32;
            label6.Text = "Contact Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(61, 308);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 31;
            label5.Text = "Specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(61, 233);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 30;
            label4.Text = "Name";
            // 
            // txt_contactInfo
            // 
            txt_contactInfo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_contactInfo.Location = new Point(571, 233);
            txt_contactInfo.Name = "txt_contactInfo";
            txt_contactInfo.Size = new Size(148, 30);
            txt_contactInfo.TabIndex = 28;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(224, 233);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(148, 30);
            txt_name.TabIndex = 27;
            // 
            // txt_dept
            // 
            txt_dept.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_dept.Location = new Point(224, 308);
            txt_dept.Name = "txt_dept";
            txt_dept.Size = new Size(148, 30);
            txt_dept.TabIndex = 26;
            txt_dept.TextChanged += textBox1_TextChanged;
            // 
            // btn_add_doc
            // 
            btn_add_doc.BackColor = Color.LightGray;
            btn_add_doc.Cursor = Cursors.Hand;
            btn_add_doc.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_add_doc.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_add_doc.FlatStyle = FlatStyle.Flat;
            btn_add_doc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_doc.Location = new Point(13, 371);
            btn_add_doc.Name = "btn_add_doc";
            btn_add_doc.Size = new Size(120, 37);
            btn_add_doc.TabIndex = 23;
            btn_add_doc.Text = "Add User";
            btn_add_doc.UseVisualStyleBackColor = false;
            btn_add_doc.Click += btn_add_doc_Click;
            // 
            // btn_update_doc
            // 
            btn_update_doc.BackColor = Color.DarkGray;
            btn_update_doc.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_update_doc.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_update_doc.FlatStyle = FlatStyle.Flat;
            btn_update_doc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_doc.Location = new Point(139, 371);
            btn_update_doc.Name = "btn_update_doc";
            btn_update_doc.Size = new Size(120, 37);
            btn_update_doc.TabIndex = 24;
            btn_update_doc.Text = "Edit User";
            btn_update_doc.UseVisualStyleBackColor = false;
            btn_update_doc.Click += btn_update_doc_Click;
            // 
            // btn_delete_doc
            // 
            btn_delete_doc.BackColor = Color.DimGray;
            btn_delete_doc.Cursor = Cursors.Hand;
            btn_delete_doc.FlatAppearance.BorderColor = Color.MidnightBlue;
            btn_delete_doc.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 42, 158);
            btn_delete_doc.FlatStyle = FlatStyle.Flat;
            btn_delete_doc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_doc.Location = new Point(265, 371);
            btn_delete_doc.Name = "btn_delete_doc";
            btn_delete_doc.Size = new Size(120, 37);
            btn_delete_doc.TabIndex = 25;
            btn_delete_doc.Text = "Delete User";
            btn_delete_doc.UseVisualStyleBackColor = false;
            btn_delete_doc.Click += btn_delete_doc_Click;
            // 
            // dgv_doctors
            // 
            dgv_doctors.BackgroundColor = Color.White;
            dgv_doctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_doctors.Location = new Point(0, 0);
            dgv_doctors.Name = "dgv_doctors";
            dgv_doctors.RowHeadersWidth = 51;
            dgv_doctors.Size = new Size(803, 216);
            dgv_doctors.TabIndex = 0;
            dgv_doctors.CellContentClick += dgv_doctors_CellContentClick;
            dgv_doctors.RowHeaderMouseDoubleClick += dgv_doctors_RowHeaderMouseDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(450, 313);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 36;
            label7.Text = "Schedule";
            // 
            // txt_schedule
            // 
            txt_schedule.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_schedule.Location = new Point(571, 308);
            txt_schedule.Name = "txt_schedule";
            txt_schedule.Size = new Size(148, 30);
            txt_schedule.TabIndex = 35;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            tabControl.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private TabControl tabControl;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox cb_role;
        private TextBox txt_password;
        private TextBox txt_username;
        private DataGridView dgv_users;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TabPage tabPage2;
        private Button btn_add_doc;
        private Button btn_update_doc;
        private Button btn_delete_doc;
        private DataGridView dgv_doctors;
        private TextBox txt_name;
        private TextBox txt_dept;
        private TextBox txt_contactInfo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_logout;
        private Button btn_logout2;
        private Label label7;
        private TextBox txt_schedule;
    }
}