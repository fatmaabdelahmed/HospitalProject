namespace first.Login
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            showPasswordCheckBox = new CheckBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.ForeColor = Color.FromArgb(64, 116, 192);
            txt_username.Location = new Point(120, 303);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "User Name";
            txt_username.Size = new Size(240, 40);
            txt_username.TabIndex = 0;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.ForeColor = Color.FromArgb(64, 116, 192);
            txt_password.Location = new Point(120, 369);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(240, 40);
            txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.White;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn_login.ForeColor = Color.FromArgb(104, 157, 215);
            btn_login.Location = new Point(120, 550);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(240, 45);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPasswordCheckBox.ForeColor = Color.White;
            showPasswordCheckBox.Location = new Point(224, 430);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(136, 24);
            showPasswordCheckBox.TabIndex = 3;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 219);
            label3.Name = "label3";
            label3.Size = new Size(354, 32);
            label3.TabIndex = 6;
            label3.Text = "Login to  your account!";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(505, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 785);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(104, 157, 215);
            panel2.Controls.Add(txt_username);
            panel2.Controls.Add(txt_password);
            panel2.Controls.Add(showPasswordCheckBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_login);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 834);
            panel2.TabIndex = 8;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1313, 833);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private CheckBox showPasswordCheckBox;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
    }
}