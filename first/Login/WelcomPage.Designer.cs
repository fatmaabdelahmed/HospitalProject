namespace first.Login
{
    partial class WelcomPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomPage));
            closeWelcomeLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            btn_login = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // closeWelcomeLabel
            // 
            closeWelcomeLabel.AutoSize = true;
            closeWelcomeLabel.BackColor = Color.Transparent;
            closeWelcomeLabel.Font = new Font("Ravie", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeWelcomeLabel.ForeColor = SystemColors.InactiveBorder;
            closeWelcomeLabel.Location = new Point(763, 9);
            closeWelcomeLabel.Name = "closeWelcomeLabel";
            closeWelcomeLabel.Size = new Size(25, 21);
            closeWelcomeLabel.TabIndex = 0;
            closeWelcomeLabel.Text = "X";
            closeWelcomeLabel.Click += closeWelcomeLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(386, 64);
            label1.TabIndex = 1;
            label1.Text = "Efficient Healthcare\r\nManagement Starts Here!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(420, 20);
            label2.TabIndex = 2;
            label2.Text = "Sign in to manage appointments, patient records, and more.";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.CornflowerBlue;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(12, 233);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(100, 35);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(24, 55);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 55);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 6;
            label4.Text = "WELCOM TO OUR SYSTEM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Transparent;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(12, 55);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 10;
            label5.Text = ".";
            // 
            // WelcomPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeWelcomeLabel);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "WelcomPage";
            Text = "WelcomPage";
            Load += WelcomPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closeWelcomeLabel;
        private Label label1;
        private Label label2;
        private Button btn_login;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}