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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            txt_username = new TextBox();
            txt_old = new TextBox();
            txt_new = new TextBox();
            txt_confirm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_edidpro = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pic_old_pass = new PictureBox();
            pict_new_pass = new PictureBox();
            pic_confirm_pass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_old_pass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pict_new_pass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_confirm_pass).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.ForeColor = Color.FromArgb(64, 116, 192);
            txt_username.Location = new Point(898, 130);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(173, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_old
            // 
            txt_old.ForeColor = Color.FromArgb(64, 116, 192);
            txt_old.Location = new Point(898, 203);
            txt_old.Name = "txt_old";
            txt_old.Size = new Size(173, 27);
            txt_old.TabIndex = 1;
            txt_old.UseSystemPasswordChar = true;
            // 
            // txt_new
            // 
            txt_new.ForeColor = Color.FromArgb(64, 116, 192);
            txt_new.Location = new Point(898, 279);
            txt_new.Name = "txt_new";
            txt_new.Size = new Size(173, 27);
            txt_new.TabIndex = 2;
            txt_new.UseSystemPasswordChar = true;
            // 
            // txt_confirm
            // 
            txt_confirm.ForeColor = Color.FromArgb(64, 116, 192);
            txt_confirm.Location = new Point(898, 358);
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Size = new Size(173, 27);
            txt_confirm.TabIndex = 3;
            txt_confirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 116, 192);
            label1.Location = new Point(670, 133);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 4;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 116, 192);
            label2.Location = new Point(670, 206);
            label2.Name = "label2";
            label2.Size = new Size(144, 24);
            label2.TabIndex = 5;
            label2.Text = "old passward";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 116, 192);
            label3.Location = new Point(670, 278);
            label3.Name = "label3";
            label3.Size = new Size(156, 24);
            label3.TabIndex = 6;
            label3.Text = "new password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 116, 192);
            label4.Location = new Point(670, 358);
            label4.Name = "label4";
            label4.Size = new Size(191, 24);
            label4.TabIndex = 7;
            label4.Text = "confirm password";
            // 
            // btn_edidpro
            // 
            btn_edidpro.BackColor = Color.FromArgb(64, 116, 192);
            btn_edidpro.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_edidpro.ForeColor = Color.White;
            btn_edidpro.Location = new Point(781, 475);
            btn_edidpro.Name = "btn_edidpro";
            btn_edidpro.Size = new Size(207, 50);
            btn_edidpro.TabIndex = 8;
            btn_edidpro.Text = "save";
            btn_edidpro.UseVisualStyleBackColor = false;
            btn_edidpro.Click += btn_edidpro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-13, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(667, 696);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(835, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pic_old_pass
            // 
            pic_old_pass.Image = (Image)resources.GetObject("pic_old_pass.Image");
            pic_old_pass.Location = new Point(1044, 206);
            pic_old_pass.Margin = new Padding(2);
            pic_old_pass.Name = "pic_old_pass";
            pic_old_pass.Size = new Size(18, 19);
            pic_old_pass.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_old_pass.TabIndex = 49;
            pic_old_pass.TabStop = false;
            pic_old_pass.Click += pic_old_pass_Click;
            // 
            // pict_new_pass
            // 
            pict_new_pass.Image = (Image)resources.GetObject("pict_new_pass.Image");
            pict_new_pass.Location = new Point(1044, 283);
            pict_new_pass.Margin = new Padding(2);
            pict_new_pass.Name = "pict_new_pass";
            pict_new_pass.Size = new Size(18, 19);
            pict_new_pass.SizeMode = PictureBoxSizeMode.StretchImage;
            pict_new_pass.TabIndex = 50;
            pict_new_pass.TabStop = false;
            pict_new_pass.Click += pict_new_pass_Click;
            // 
            // pic_confirm_pass
            // 
            pic_confirm_pass.Image = (Image)resources.GetObject("pic_confirm_pass.Image");
            pic_confirm_pass.Location = new Point(1044, 363);
            pic_confirm_pass.Margin = new Padding(2);
            pic_confirm_pass.Name = "pic_confirm_pass";
            pic_confirm_pass.Size = new Size(18, 19);
            pic_confirm_pass.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_confirm_pass.TabIndex = 51;
            pic_confirm_pass.TabStop = false;
            pic_confirm_pass.Click += pic_confirm_pass_Click;
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1083, 669);
            Controls.Add(pic_confirm_pass);
            Controls.Add(pict_new_pass);
            Controls.Add(pic_old_pass);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_old_pass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pict_new_pass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_confirm_pass).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pic_old_pass;
        private PictureBox pict_new_pass;
        private PictureBox pic_confirm_pass;
    }
}