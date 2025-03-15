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
            btn_logout = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btn_reports = new Button();
            label8 = new Label();
            btn_doctor = new Button();
            btn_user = new Button();
            SuspendLayout();
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(1114, 12);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(187, 37);
            btn_logout.TabIndex = 27;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btn_reports
            // 
            btn_reports.Location = new Point(921, 12);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(187, 37);
            btn_reports.TabIndex = 28;
            btn_reports.Text = "Reports ";
            btn_reports.UseVisualStyleBackColor = true;
            btn_reports.Click += btn_reports_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 12);
            label8.Name = "label8";
            label8.Size = new Size(331, 40);
            label8.TabIndex = 29;
            label8.Text = "Admin Dashboard";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_doctor
            // 
            btn_doctor.Location = new Point(728, 12);
            btn_doctor.Name = "btn_doctor";
            btn_doctor.Size = new Size(187, 37);
            btn_doctor.TabIndex = 30;
            btn_doctor.Text = "Doctor Management";
            btn_doctor.UseVisualStyleBackColor = true;
            btn_doctor.Click += btn_doctor_Click;
            // 
            // btn_user
            // 
            btn_user.Location = new Point(535, 12);
            btn_user.Name = "btn_user";
            btn_user.Size = new Size(187, 37);
            btn_user.TabIndex = 31;
            btn_user.Text = "User Management";
            btn_user.UseVisualStyleBackColor = true;
            btn_user.Click += btn_user_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1313, 833);
            Controls.Add(btn_user);
            Controls.Add(btn_doctor);
            Controls.Add(label8);
            Controls.Add(btn_reports);
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
        private Button btn_reports;
        private Label label8;
        private Button btn_doctor;
        private Button btn_user;
    }
}