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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            btn_logout = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label8 = new Label();
            lb_user = new Label();
            lb_doctor = new Label();
            lb_reports = new Label();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(64, 116, 192);
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(1061, 776);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(240, 45);
            btn_logout.TabIndex = 27;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 116, 192);
            label8.Location = new Point(12, 12);
            label8.Name = "label8";
            label8.Size = new Size(331, 40);
            label8.TabIndex = 29;
            label8.Text = "Admin Dashboard";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_user
            // 
            lb_user.AutoSize = true;
            lb_user.BackColor = Color.Transparent;
            lb_user.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lb_user.ForeColor = Color.FromArgb(64, 116, 192);
            lb_user.Location = new Point(827, 24);
            lb_user.Name = "lb_user";
            lb_user.Size = new Size(166, 25);
            lb_user.TabIndex = 32;
            lb_user.Text = "User Management";
            lb_user.Click += lb_user_Click;
            // 
            // lb_doctor
            // 
            lb_doctor.AutoSize = true;
            lb_doctor.BackColor = Color.Transparent;
            lb_doctor.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lb_doctor.ForeColor = Color.FromArgb(64, 116, 192);
            lb_doctor.Location = new Point(1014, 24);
            lb_doctor.Name = "lb_doctor";
            lb_doctor.Size = new Size(185, 25);
            lb_doctor.TabIndex = 33;
            lb_doctor.Text = "Doctor Management";
            lb_doctor.Click += lb_doctor_Click;
            // 
            // lb_reports
            // 
            lb_reports.AutoSize = true;
            lb_reports.BackColor = Color.Transparent;
            lb_reports.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lb_reports.ForeColor = Color.FromArgb(64, 116, 192);
            lb_reports.Location = new Point(1218, 24);
            lb_reports.Name = "lb_reports";
            lb_reports.Size = new Size(83, 25);
            lb_reports.TabIndex = 34;
            lb_reports.Text = "Reports ";
            lb_reports.Click += lb_reports_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1313, 833);
            Controls.Add(lb_reports);
            Controls.Add(lb_doctor);
            Controls.Add(lb_user);
            Controls.Add(label8);
            Controls.Add(btn_logout);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btn_logout;
        private Label label8;
        private Label lb_user;
        private Label lb_doctor;
        private Label lb_reports;
    }
}