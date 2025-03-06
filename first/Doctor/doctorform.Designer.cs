
namespace first.Doctor
{
    partial class doctorform
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_update_profile = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_sched_profile = new TextBox();
            txt_con_profile = new TextBox();
            txt_speci_profile = new TextBox();
            txt_name_profile = new TextBox();
            tabPage2 = new TabPage();
            dgv_appoinments = new DataGridView();
            tabPage3 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            comboBox1 = new ComboBox();
            txt_oldpass_profile = new TextBox();
            txt_newpass_profile = new TextBox();
            txt_conpass_profile = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appoinments).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1522, 771);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txt_conpass_profile);
            tabPage1.Controls.Add(txt_newpass_profile);
            tabPage1.Controls.Add(txt_oldpass_profile);
            tabPage1.Controls.Add(btn_update_profile);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txt_sched_profile);
            tabPage1.Controls.Add(txt_con_profile);
            tabPage1.Controls.Add(txt_speci_profile);
            tabPage1.Controls.Add(txt_name_profile);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1506, 717);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "profile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_update_profile
            // 
            btn_update_profile.Location = new Point(1093, 460);
            btn_update_profile.Name = "btn_update_profile";
            btn_update_profile.Size = new Size(150, 46);
            btn_update_profile.TabIndex = 8;
            btn_update_profile.Text = "update";
            btn_update_profile.UseVisualStyleBackColor = true;
            btn_update_profile.Click += btn_update_profile_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 365);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 7;
            label4.Text = "schedual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 267);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 6;
            label3.Text = "contactinfo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 182);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 5;
            label2.Text = "specialization";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 114);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // txt_sched_profile
            // 
            txt_sched_profile.Location = new Point(352, 358);
            txt_sched_profile.Name = "txt_sched_profile";
            txt_sched_profile.Size = new Size(490, 39);
            txt_sched_profile.TabIndex = 3;
            // 
            // txt_con_profile
            // 
            txt_con_profile.Location = new Point(352, 264);
            txt_con_profile.Name = "txt_con_profile";
            txt_con_profile.Size = new Size(490, 39);
            txt_con_profile.TabIndex = 2;
            // 
            // txt_speci_profile
            // 
            txt_speci_profile.Location = new Point(352, 185);
            txt_speci_profile.Name = "txt_speci_profile";
            txt_speci_profile.Size = new Size(490, 39);
            txt_speci_profile.TabIndex = 1;
            // 
            // txt_name_profile
            // 
            txt_name_profile.Location = new Point(352, 100);
            txt_name_profile.Name = "txt_name_profile";
            txt_name_profile.Size = new Size(490, 39);
            txt_name_profile.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgv_appoinments);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1506, 717);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "appoiments";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_appoinments
            // 
            dgv_appoinments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appoinments.Location = new Point(46, 44);
            dgv_appoinments.Name = "dgv_appoinments";
            dgv_appoinments.RowHeadersWidth = 82;
            dgv_appoinments.Size = new Size(1389, 523);
            dgv_appoinments.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1506, 717);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "medical rec";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(65, 64);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 5;
            button4.Text = "allm_rec";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1117, 670);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 4;
            button3.Text = "remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(649, 668);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(182, 666);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(98, 186);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(1314, 428);
            dataGridView2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1012, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(423, 40);
            comboBox1.TabIndex = 0;
            // 
            // txt_oldpass_profile
            // 
            txt_oldpass_profile.Location = new Point(352, 434);
            txt_oldpass_profile.Name = "txt_oldpass_profile";
            txt_oldpass_profile.Size = new Size(490, 39);
            txt_oldpass_profile.TabIndex = 9;
            // 
            // txt_newpass_profile
            // 
            txt_newpass_profile.Location = new Point(352, 504);
            txt_newpass_profile.Name = "txt_newpass_profile";
            txt_newpass_profile.Size = new Size(503, 39);
            txt_newpass_profile.TabIndex = 10;
            // 
            // txt_conpass_profile
            // 
            txt_conpass_profile.Location = new Point(359, 589);
            txt_conpass_profile.Name = "txt_conpass_profile";
            txt_conpass_profile.Size = new Size(496, 39);
            txt_conpass_profile.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 441);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 12;
            label5.Text = "old pass";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 524);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 13;
            label6.Text = "new pass";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 596);
            label7.Name = "label7";
            label7.Size = new Size(149, 32);
            label7.TabIndex = 14;
            label7.Text = "confirm pass";
            // 
            // doctorform
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 780);
            Controls.Add(tabControl1);
            Name = "doctorform";
            Text = "Form1";
            Load += doctorform_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_appoinments).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_sched_profile;
        private TextBox txt_con_profile;
        private TextBox txt_speci_profile;
        private TextBox txt_name_profile;
        private DataGridView dgv_appoinments;
        private TabPage tabPage3;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Button button4;
        private Button btn_update_profile;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_conpass_profile;
        private TextBox txt_newpass_profile;
        private TextBox txt_oldpass_profile;
    }
}