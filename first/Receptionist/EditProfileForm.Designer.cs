namespace first.Receptionist
{
    partial class EditProfileForm
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
            txt_username = new TextBox();
            txt_old = new TextBox();
            txt_new = new TextBox();
            txt_confirm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_edidpro = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(418, 91);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(125, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_old
            // 
            txt_old.Location = new Point(418, 154);
            txt_old.Name = "txt_old";
            txt_old.Size = new Size(125, 27);
            txt_old.TabIndex = 1;
            // 
            // txt_new
            // 
            txt_new.Location = new Point(418, 244);
            txt_new.Name = "txt_new";
            txt_new.Size = new Size(125, 27);
            txt_new.TabIndex = 2;
            // 
            // txt_confirm
            // 
            txt_confirm.Location = new Point(418, 312);
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Size = new Size(125, 27);
            txt_confirm.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 97);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 4;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 161);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "old passward";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 251);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "new password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 319);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 7;
            label4.Text = "confirm password";
            // 
            // btn_edidpro
            // 
            btn_edidpro.Location = new Point(449, 453);
            btn_edidpro.Name = "btn_edidpro";
            btn_edidpro.Size = new Size(94, 29);
            btn_edidpro.TabIndex = 8;
            btn_edidpro.Text = "save";
            btn_edidpro.UseVisualStyleBackColor = true;
            btn_edidpro.Click += btn_edidpro_Click;
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 686);
            Controls.Add(btn_edidpro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_confirm);
            Controls.Add(txt_new);
            Controls.Add(txt_old);
            Controls.Add(txt_username);
            Name = "EditProfileForm";
            Text = "EditProfileForm";
            Load += EditProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_old;
        private TextBox txt_new;
        private TextBox txt_confirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_edidpro;
    }
}