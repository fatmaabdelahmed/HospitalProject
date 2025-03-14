
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctorform));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_logout = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_conpass_profile = new TextBox();
            txt_newpass_profile = new TextBox();
            txt_oldpass_profile = new TextBox();
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
            pic_bake_appintment = new PictureBox();
            btn_all_appintment = new Button();
            btn_uppcoming = new Button();
            com_status = new ComboBox();
            label13 = new Label();
            dgv_appoinments = new DataGridView();
            tabPage3 = new TabPage();
            pic_bake_medical_rec = new PictureBox();
            label15 = new Label();
            btn_report_browse = new Button();
            btn_browse_result = new Button();
            label12 = new Label();
            label10 = new Label();
            txt_report_medirec = new TextBox();
            txt_lab_res_medirec = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            txt_treatment_medicrec = new TextBox();
            txt_presc_medicrec = new TextBox();
            txt_diag_medicrec = new TextBox();
            btn_allrec = new Button();
            btn_add_medirec = new Button();
            dgv_medical_rec = new DataGridView();
            com_paiens_name_medrec = new ComboBox();
            tabPage4 = new TabPage();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            dgv_get_all_medicalrecords = new DataGridView();
            com_doctor = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bake_appintment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_appoinments).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bake_medical_rec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_medical_rec).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_get_all_medicalrecords).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.ItemSize = new Size(100, 38);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1487, 1006);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(btn_logout);
            tabPage1.Controls.Add(pictureBox1);
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
            tabPage1.Size = new Size(1471, 952);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "   Doctor Profile   ";
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(42, 59, 141);
            btn_logout.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(32, 26);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(201, 84);
            btn_logout.TabIndex = 47;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1103, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.875F);
            label7.ForeColor = Color.FromArgb(43, 57, 145);
            label7.Location = new Point(931, 680);
            label7.Name = "label7";
            label7.Size = new Size(180, 35);
            label7.TabIndex = 45;
            label7.Text = "Confirm Pass";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.875F);
            label6.ForeColor = Color.FromArgb(43, 57, 145);
            label6.Location = new Point(931, 600);
            label6.Name = "label6";
            label6.Size = new Size(137, 35);
            label6.TabIndex = 44;
            label6.Text = "New Pass";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.875F);
            label5.ForeColor = Color.FromArgb(43, 57, 145);
            label5.Location = new Point(931, 520);
            label5.Name = "label5";
            label5.Size = new Size(125, 35);
            label5.TabIndex = 43;
            label5.Text = "Old Pass";
            // 
            // txt_conpass_profile
            // 
            txt_conpass_profile.Font = new Font("Tahoma", 10.875F);
            txt_conpass_profile.ForeColor = Color.FromArgb(43, 57, 145);
            txt_conpass_profile.Location = new Point(1152, 675);
            txt_conpass_profile.Name = "txt_conpass_profile";
            txt_conpass_profile.Size = new Size(285, 43);
            txt_conpass_profile.TabIndex = 42;
            // 
            // txt_newpass_profile
            // 
            txt_newpass_profile.Font = new Font("Tahoma", 10.875F);
            txt_newpass_profile.ForeColor = Color.FromArgb(43, 57, 145);
            txt_newpass_profile.Location = new Point(1152, 594);
            txt_newpass_profile.Name = "txt_newpass_profile";
            txt_newpass_profile.Size = new Size(285, 43);
            txt_newpass_profile.TabIndex = 41;
            // 
            // txt_oldpass_profile
            // 
            txt_oldpass_profile.Font = new Font("Tahoma", 10.875F);
            txt_oldpass_profile.ForeColor = Color.FromArgb(43, 57, 145);
            txt_oldpass_profile.Location = new Point(1152, 513);
            txt_oldpass_profile.Name = "txt_oldpass_profile";
            txt_oldpass_profile.Size = new Size(279, 43);
            txt_oldpass_profile.TabIndex = 40;
            // 
            // btn_update_profile
            // 
            btn_update_profile.BackColor = Color.FromArgb(42, 59, 141);
            btn_update_profile.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update_profile.ForeColor = Color.White;
            btn_update_profile.Location = new Point(1067, 776);
            btn_update_profile.Name = "btn_update_profile";
            btn_update_profile.Size = new Size(258, 76);
            btn_update_profile.TabIndex = 39;
            btn_update_profile.Text = "Update";
            btn_update_profile.UseVisualStyleBackColor = false;
            btn_update_profile.Click += btn_update_profile_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.875F);
            label4.ForeColor = Color.FromArgb(43, 57, 145);
            label4.Location = new Point(931, 440);
            label4.Name = "label4";
            label4.Size = new Size(129, 35);
            label4.TabIndex = 38;
            label4.Text = "Schedual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.875F);
            label3.ForeColor = Color.FromArgb(43, 57, 145);
            label3.Location = new Point(931, 360);
            label3.Name = "label3";
            label3.Size = new Size(160, 35);
            label3.TabIndex = 37;
            label3.Text = "Contactinfo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.875F);
            label2.ForeColor = Color.FromArgb(43, 57, 145);
            label2.Location = new Point(931, 280);
            label2.Name = "label2";
            label2.Size = new Size(188, 35);
            label2.TabIndex = 36;
            label2.Text = "Specialization";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.875F);
            label1.ForeColor = Color.FromArgb(43, 57, 145);
            label1.Location = new Point(931, 200);
            label1.Name = "label1";
            label1.Size = new Size(88, 35);
            label1.TabIndex = 35;
            label1.Text = "Name";
            // 
            // txt_sched_profile
            // 
            txt_sched_profile.Font = new Font("Tahoma", 10.875F);
            txt_sched_profile.ForeColor = Color.FromArgb(43, 57, 145);
            txt_sched_profile.Location = new Point(1152, 432);
            txt_sched_profile.Name = "txt_sched_profile";
            txt_sched_profile.Size = new Size(279, 43);
            txt_sched_profile.TabIndex = 34;
            // 
            // txt_con_profile
            // 
            txt_con_profile.Font = new Font("Tahoma", 10.875F);
            txt_con_profile.ForeColor = Color.FromArgb(43, 57, 145);
            txt_con_profile.Location = new Point(1152, 351);
            txt_con_profile.Name = "txt_con_profile";
            txt_con_profile.Size = new Size(279, 43);
            txt_con_profile.TabIndex = 33;
            // 
            // txt_speci_profile
            // 
            txt_speci_profile.Font = new Font("Tahoma", 10.875F);
            txt_speci_profile.ForeColor = Color.FromArgb(43, 57, 145);
            txt_speci_profile.Location = new Point(1152, 270);
            txt_speci_profile.Name = "txt_speci_profile";
            txt_speci_profile.Size = new Size(279, 43);
            txt_speci_profile.TabIndex = 32;
            // 
            // txt_name_profile
            // 
            txt_name_profile.Font = new Font("Tahoma", 10.875F);
            txt_name_profile.ForeColor = Color.FromArgb(43, 57, 145);
            txt_name_profile.Location = new Point(1152, 189);
            txt_name_profile.Name = "txt_name_profile";
            txt_name_profile.Size = new Size(279, 43);
            txt_name_profile.TabIndex = 31;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.Screenshot_2025_03_13_173946;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(pic_bake_appintment);
            tabPage2.Controls.Add(btn_all_appintment);
            tabPage2.Controls.Add(btn_uppcoming);
            tabPage2.Controls.Add(com_status);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(dgv_appoinments);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1471, 952);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "   Appoiments   ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pic_bake_appintment
            // 
            pic_bake_appintment.Image = (Image)resources.GetObject("pic_bake_appintment.Image");
            pic_bake_appintment.Location = new Point(24, 21);
            pic_bake_appintment.Name = "pic_bake_appintment";
            pic_bake_appintment.Size = new Size(77, 52);
            pic_bake_appintment.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_bake_appintment.TabIndex = 9;
            pic_bake_appintment.TabStop = false;
            pic_bake_appintment.Click += pic_bake_medical_rec_Click;
            // 
            // btn_all_appintment
            // 
            btn_all_appintment.BackColor = Color.FromArgb(74, 124, 185);
            btn_all_appintment.Font = new Font("Segoe UI", 12F);
            btn_all_appintment.ForeColor = Color.White;
            btn_all_appintment.Location = new Point(1138, 211);
            btn_all_appintment.Name = "btn_all_appintment";
            btn_all_appintment.Size = new Size(300, 85);
            btn_all_appintment.TabIndex = 8;
            btn_all_appintment.Text = "All Appintment";
            btn_all_appintment.UseVisualStyleBackColor = false;
            btn_all_appintment.Click += btn_all_appintment_Click;
            // 
            // btn_uppcoming
            // 
            btn_uppcoming.BackColor = Color.FromArgb(74, 124, 185);
            btn_uppcoming.Font = new Font("Segoe UI", 12F);
            btn_uppcoming.ForeColor = Color.White;
            btn_uppcoming.Location = new Point(1138, 64);
            btn_uppcoming.Name = "btn_uppcoming";
            btn_uppcoming.Size = new Size(300, 106);
            btn_uppcoming.TabIndex = 7;
            btn_uppcoming.Text = " Upcoming\r\nAppointments";
            btn_uppcoming.UseVisualStyleBackColor = false;
            btn_uppcoming.Click += btn_uppcoming_Click;
            // 
            // com_status
            // 
            com_status.Font = new Font("Tahoma", 12F);
            com_status.ForeColor = Color.FromArgb(48, 93, 150);
            com_status.FormattingEnabled = true;
            com_status.Location = new Point(201, 285);
            com_status.Name = "com_status";
            com_status.Size = new Size(345, 47);
            com_status.TabIndex = 6;
            com_status.SelectedIndexChanged += com_status_SelectedValueChanged;
            com_status.Click += com_status_SelectedValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(48, 93, 150);
            label13.Location = new Point(36, 285);
            label13.Name = "label13";
            label13.Size = new Size(118, 39);
            label13.TabIndex = 5;
            label13.Text = "Status";
            // 
            // dgv_appoinments
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgv_appoinments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_appoinments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_appoinments.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_appoinments.Location = new Point(192, 471);
            dgv_appoinments.Name = "dgv_appoinments";
            dgv_appoinments.RowHeadersWidth = 82;
            dgv_appoinments.Size = new Size(1078, 453);
            dgv_appoinments.TabIndex = 0;
            dgv_appoinments.CellMouseDoubleClick += dgv_appoinments_CellMouseDoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources._4990224;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(pic_bake_medical_rec);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(btn_report_browse);
            tabPage3.Controls.Add(btn_browse_result);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(txt_report_medirec);
            tabPage3.Controls.Add(txt_lab_res_medirec);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(txt_treatment_medicrec);
            tabPage3.Controls.Add(txt_presc_medicrec);
            tabPage3.Controls.Add(txt_diag_medicrec);
            tabPage3.Controls.Add(btn_allrec);
            tabPage3.Controls.Add(btn_add_medirec);
            tabPage3.Controls.Add(dgv_medical_rec);
            tabPage3.Controls.Add(com_paiens_name_medrec);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1471, 952);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "   Medical Records   ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pic_bake_medical_rec
            // 
            pic_bake_medical_rec.Image = (Image)resources.GetObject("pic_bake_medical_rec.Image");
            pic_bake_medical_rec.Location = new Point(32, 20);
            pic_bake_medical_rec.Name = "pic_bake_medical_rec";
            pic_bake_medical_rec.Size = new Size(77, 52);
            pic_bake_medical_rec.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_bake_medical_rec.TabIndex = 24;
            pic_bake_medical_rec.TabStop = false;
            pic_bake_medical_rec.Click += pic_bake_medical_rec_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.MediumBlue;
            label15.Location = new Point(848, 54);
            label15.Name = "label15";
            label15.Size = new Size(104, 35);
            label15.TabIndex = 23;
            label15.Text = "Patient";
            // 
            // btn_report_browse
            // 
            btn_report_browse.BackColor = Color.FromArgb(26, 114, 188);
            btn_report_browse.ForeColor = Color.White;
            btn_report_browse.Location = new Point(620, 638);
            btn_report_browse.Name = "btn_report_browse";
            btn_report_browse.Size = new Size(103, 46);
            btn_report_browse.TabIndex = 22;
            btn_report_browse.Text = "Browes";
            btn_report_browse.UseVisualStyleBackColor = false;
            btn_report_browse.Click += btn_report_browse_Click;
            // 
            // btn_browse_result
            // 
            btn_browse_result.BackColor = Color.FromArgb(26, 114, 188);
            btn_browse_result.ForeColor = Color.White;
            btn_browse_result.Location = new Point(620, 551);
            btn_browse_result.Name = "btn_browse_result";
            btn_browse_result.Size = new Size(103, 46);
            btn_browse_result.TabIndex = 20;
            btn_browse_result.Text = "Browes";
            btn_browse_result.UseVisualStyleBackColor = false;
            btn_browse_result.Click += btn_browse_result_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 10.875F);
            label12.ForeColor = Color.MediumBlue;
            label12.Location = new Point(18, 629);
            label12.Name = "label12";
            label12.Size = new Size(100, 35);
            label12.TabIndex = 19;
            label12.Text = "Report";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.875F);
            label10.ForeColor = Color.MediumBlue;
            label10.Location = new Point(18, 551);
            label10.Name = "label10";
            label10.Size = new Size(141, 35);
            label10.TabIndex = 18;
            label10.Text = "lab Result";
            // 
            // txt_report_medirec
            // 
            txt_report_medirec.Font = new Font("Tahoma", 10.875F);
            txt_report_medirec.ForeColor = Color.FromArgb(0, 81, 161);
            txt_report_medirec.Location = new Point(245, 638);
            txt_report_medirec.Name = "txt_report_medirec";
            txt_report_medirec.Size = new Size(339, 43);
            txt_report_medirec.TabIndex = 17;
            // 
            // txt_lab_res_medirec
            // 
            txt_lab_res_medirec.Font = new Font("Tahoma", 10.875F);
            txt_lab_res_medirec.ForeColor = Color.FromArgb(0, 81, 161);
            txt_lab_res_medirec.Location = new Point(245, 548);
            txt_lab_res_medirec.Name = "txt_lab_res_medirec";
            txt_lab_res_medirec.Size = new Size(339, 43);
            txt_lab_res_medirec.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 10.875F);
            label11.ForeColor = Color.MediumBlue;
            label11.Location = new Point(18, 461);
            label11.Name = "label11";
            label11.Size = new Size(210, 35);
            label11.TabIndex = 15;
            label11.Text = "Treatment Plan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.875F);
            label9.ForeColor = Color.MediumBlue;
            label9.Location = new Point(18, 362);
            label9.Name = "label9";
            label9.Size = new Size(164, 35);
            label9.TabIndex = 13;
            label9.Text = "Prescription";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.875F);
            label8.ForeColor = Color.MediumBlue;
            label8.Location = new Point(18, 278);
            label8.Name = "label8";
            label8.Size = new Size(138, 35);
            label8.TabIndex = 12;
            label8.Text = "Diagnosis";
            // 
            // txt_treatment_medicrec
            // 
            txt_treatment_medicrec.Font = new Font("Tahoma", 10.875F);
            txt_treatment_medicrec.ForeColor = Color.FromArgb(0, 81, 161);
            txt_treatment_medicrec.Location = new Point(245, 458);
            txt_treatment_medicrec.Name = "txt_treatment_medicrec";
            txt_treatment_medicrec.Size = new Size(335, 43);
            txt_treatment_medicrec.TabIndex = 9;
            // 
            // txt_presc_medicrec
            // 
            txt_presc_medicrec.Font = new Font("Tahoma", 10.875F);
            txt_presc_medicrec.ForeColor = Color.FromArgb(0, 81, 161);
            txt_presc_medicrec.Location = new Point(245, 368);
            txt_presc_medicrec.Name = "txt_presc_medicrec";
            txt_presc_medicrec.Size = new Size(335, 43);
            txt_presc_medicrec.TabIndex = 7;
            // 
            // txt_diag_medicrec
            // 
            txt_diag_medicrec.Font = new Font("Tahoma", 10.875F);
            txt_diag_medicrec.ForeColor = Color.FromArgb(0, 81, 161);
            txt_diag_medicrec.Location = new Point(245, 278);
            txt_diag_medicrec.Name = "txt_diag_medicrec";
            txt_diag_medicrec.Size = new Size(335, 43);
            txt_diag_medicrec.TabIndex = 6;
            // 
            // btn_allrec
            // 
            btn_allrec.BackColor = Color.FromArgb(0, 80, 161);
            btn_allrec.Font = new Font("Segoe UI", 10.875F);
            btn_allrec.ForeColor = Color.White;
            btn_allrec.Location = new Point(82, 866);
            btn_allrec.Name = "btn_allrec";
            btn_allrec.Size = new Size(314, 74);
            btn_allrec.TabIndex = 5;
            btn_allrec.Text = "All Medical Records";
            btn_allrec.UseVisualStyleBackColor = false;
            btn_allrec.Click += btn_allrec_Click;
            // 
            // btn_add_medirec
            // 
            btn_add_medirec.BackColor = Color.FromArgb(0, 81, 161);
            btn_add_medirec.Font = new Font("Segoe UI", 10.875F);
            btn_add_medirec.ForeColor = Color.White;
            btn_add_medirec.Location = new Point(1086, 866);
            btn_add_medirec.Name = "btn_add_medirec";
            btn_add_medirec.Size = new Size(190, 65);
            btn_add_medirec.TabIndex = 2;
            btn_add_medirec.Text = "Add";
            btn_add_medirec.UseVisualStyleBackColor = false;
            btn_add_medirec.Click += btn_add_medirec_Click;
            // 
            // dgv_medical_rec
            // 
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 53, 134);
            dgv_medical_rec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_medical_rec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_medical_rec.Location = new Point(745, 459);
            dgv_medical_rec.Name = "dgv_medical_rec";
            dgv_medical_rec.RowHeadersWidth = 82;
            dgv_medical_rec.Size = new Size(681, 365);
            dgv_medical_rec.TabIndex = 1;
            dgv_medical_rec.CellContentDoubleClick += dgv_medical_rec_CellContentDoubleClick;
            // 
            // com_paiens_name_medrec
            // 
            com_paiens_name_medrec.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            com_paiens_name_medrec.ForeColor = Color.FromArgb(0, 81, 161);
            com_paiens_name_medrec.FormattingEnabled = true;
            com_paiens_name_medrec.Location = new Point(971, 49);
            com_paiens_name_medrec.Name = "com_paiens_name_medrec";
            com_paiens_name_medrec.Size = new Size(423, 48);
            com_paiens_name_medrec.TabIndex = 0;
            com_paiens_name_medrec.SelectedValueChanged += com_paiens_name_medrec_SelectedValueChanged;
            com_paiens_name_medrec.Click += com_paiens_name_medrec_SelectedValueChanged;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(pictureBox2);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(dgv_get_all_medicalrecords);
            tabPage4.Controls.Add(com_doctor);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1471, 952);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "   All Medical Records   ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btn_back_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(0, 53, 134);
            label14.Location = new Point(873, 88);
            label14.Name = "label14";
            label14.Size = new Size(100, 35);
            label14.TabIndex = 5;
            label14.Text = "Doctor";
            // 
            // dgv_get_all_medicalrecords
            // 
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 53, 134);
            dgv_get_all_medicalrecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_get_all_medicalrecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_get_all_medicalrecords.Location = new Point(75, 542);
            dgv_get_all_medicalrecords.Name = "dgv_get_all_medicalrecords";
            dgv_get_all_medicalrecords.RowHeadersWidth = 82;
            dgv_get_all_medicalrecords.Size = new Size(1322, 381);
            dgv_get_all_medicalrecords.TabIndex = 3;
            dgv_get_all_medicalrecords.CellContentDoubleClick += dgv_medical_rec_CellContentDoubleClick;
            // 
            // com_doctor
            // 
            com_doctor.Font = new Font("Tahoma", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            com_doctor.ForeColor = Color.FromArgb(0, 53, 134);
            com_doctor.FormattingEnabled = true;
            com_doctor.Location = new Point(1000, 81);
            com_doctor.Name = "com_doctor";
            com_doctor.Size = new Size(423, 43);
            com_doctor.TabIndex = 2;
            com_doctor.SelectedValueChanged += com_doctor_SelectedValueChanged;
            com_doctor.Click += com_doctor_SelectedValueChanged;
            // 
            // doctorform
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 999);
            Controls.Add(tabControl1);
            Name = "doctorform";
            Text = "Form1";
            Load += doctorform_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bake_appintment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_appoinments).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bake_medical_rec).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_medical_rec).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_get_all_medicalrecords).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgv_appoinments;
        private TabPage tabPage3;
        private Button btn_add_medirec;
        private DataGridView dgv_medical_rec;
        private ComboBox com_paiens_name_medrec;
        private Button btn_allrec;
        private TextBox txt_treatment_medicrec;
        private TextBox txt_presc_medicrec;
        private TextBox txt_diag_medicrec;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label10;
        private TextBox txt_report_medirec;
        private TextBox txt_lab_res_medirec;
        private Button btn_browse_result;
        private Button btn_report_browse;
        private TabPage tabPage4;
        private DataGridView dgv_get_all_medicalrecords;
        private ComboBox com_doctor;
        private Label label14;
        private Button btn_all_appintment;
        private Button btn_uppcoming;
        private ComboBox com_status;
        private Label label13;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_conpass_profile;
        private TextBox txt_newpass_profile;
        private TextBox txt_oldpass_profile;
        private Button btn_update_profile;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_sched_profile;
        private TextBox txt_con_profile;
        private TextBox txt_speci_profile;
        private TextBox txt_name_profile;
        private Label label15;
        private PictureBox pictureBox2;
        private Button btn_logout;
        private PictureBox pic_bake_appintment;
        private PictureBox pic_bake_medical_rec;
    }
}