namespace first.Reports
{
    partial class QRcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRcode));
            pictureBoxQRCode = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.BackColor = Color.FromArgb(230, 240, 241);
            pictureBoxQRCode.Location = new Point(421, 63);
            pictureBoxQRCode.Margin = new Padding(2, 2, 2, 2);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(322, 368);
            pictureBoxQRCode.TabIndex = 0;
            pictureBoxQRCode.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 240, 241);
            button1.Font = new Font("Tahoma", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(23, 405);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(170, 41);
            button1.TabIndex = 1;
            button1.Text = "Generat QR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnGenerateQR_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 13);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // QRcode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 519);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBoxQRCode);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "QRcode";
            Text = "QRcode";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxQRCode;
        private Button button1;
        private PictureBox pictureBox1;
    }
}