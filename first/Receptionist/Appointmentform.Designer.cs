namespace first.Receptionist
{
    partial class Appointmentform
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_serch = new TextBox();
            btn_sear = new Button();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            cb_stat = new ComboBox();
            dtp_app = new DateTimePicker();
            cb_patie = new ComboBox();
            cb_doc = new ComboBox();
            dgv_appo = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appo).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txt_serch);
            panel3.Controls.Add(btn_sear);
            panel3.Controls.Add(btn_delete);
            panel3.Controls.Add(btn_edit);
            panel3.Controls.Add(btn_add);
            panel3.Controls.Add(cb_stat);
            panel3.Controls.Add(dtp_app);
            panel3.Controls.Add(cb_patie);
            panel3.Controls.Add(cb_doc);
            panel3.Controls.Add(dgv_appo);
            panel3.Location = new Point(4, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1140, 745);
            panel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 116, 192);
            label5.Location = new Point(723, 303);
            label5.Name = "label5";
            label5.Size = new Size(74, 24);
            label5.TabIndex = 18;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 116, 192);
            label4.Location = new Point(723, 236);
            label4.Name = "label4";
            label4.Size = new Size(200, 24);
            label4.TabIndex = 17;
            label4.Text = "Appointment Date ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 116, 192);
            label3.Location = new Point(723, 166);
            label3.Name = "label3";
            label3.Size = new Size(146, 24);
            label3.TabIndex = 16;
            label3.Text = "Patient Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 116, 192);
            label2.Location = new Point(723, 99);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 15;
            label2.Text = "Dr Name\r\n";
            // 
            // txt_serch
            // 
            txt_serch.Location = new Point(18, 17);
            txt_serch.Name = "txt_serch";
            txt_serch.Size = new Size(699, 27);
            txt_serch.TabIndex = 9;
            // 
            // btn_sear
            // 
            btn_sear.BackColor = Color.FromArgb(64, 116, 192);
            btn_sear.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_sear.ForeColor = Color.White;
            btn_sear.Location = new Point(799, 17);
            btn_sear.Name = "btn_sear";
            btn_sear.Size = new Size(121, 38);
            btn_sear.TabIndex = 8;
            btn_sear.Text = "Search";
            btn_sear.UseVisualStyleBackColor = false;
            btn_sear.Click += btn_sear_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(64, 116, 192);
            btn_delete.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(814, 620);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(207, 50);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(64, 116, 192);
            btn_edit.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(814, 538);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(207, 50);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(64, 116, 192);
            btn_add.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(814, 471);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(207, 50);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // cb_stat
            // 
            cb_stat.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            cb_stat.ForeColor = Color.FromArgb(64, 116, 192);
            cb_stat.FormattingEnabled = true;
            cb_stat.Location = new Point(918, 303);
            cb_stat.Name = "cb_stat";
            cb_stat.Size = new Size(173, 30);
            cb_stat.TabIndex = 4;
            // 
            // dtp_app
            // 
            dtp_app.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_app.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            dtp_app.Format = DateTimePickerFormat.Custom;
            dtp_app.Location = new Point(918, 236);
            dtp_app.Name = "dtp_app";
            dtp_app.ShowUpDown = true;
            dtp_app.Size = new Size(173, 29);
            dtp_app.TabIndex = 3;
            // 
            // cb_patie
            // 
            cb_patie.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            cb_patie.ForeColor = Color.FromArgb(64, 116, 192);
            cb_patie.FormattingEnabled = true;
            cb_patie.Location = new Point(918, 156);
            cb_patie.Name = "cb_patie";
            cb_patie.Size = new Size(173, 30);
            cb_patie.TabIndex = 2;
            // 
            // cb_doc
            // 
            cb_doc.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            cb_doc.ForeColor = Color.FromArgb(64, 116, 192);
            cb_doc.FormattingEnabled = true;
            cb_doc.Location = new Point(918, 99);
            cb_doc.Name = "cb_doc";
            cb_doc.Size = new Size(173, 30);
            cb_doc.TabIndex = 1;
            // 
            // dgv_appo
            // 
            dgv_appo.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 116, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_appo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_appo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 116, 192);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_appo.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_appo.EnableHeadersVisualStyles = false;
            dgv_appo.Location = new Point(18, 78);
            dgv_appo.Name = "dgv_appo";
            dgv_appo.RowHeadersWidth = 51;
            dgv_appo.Size = new Size(699, 652);
            dgv_appo.TabIndex = 0;
            dgv_appo.RowHeaderMouseDoubleClick += dgv_appo_RowHeaderMouseDoubleClick;
            // 
            // Appointmentform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1156, 757);

          //  ClientSize = new Size(1313, 833);

            Controls.Add(panel3);
            Name = "Appointmentform";
            Text = "Appointmentform";
            Load += Appointmentform_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox txt_serch;
        private Button btn_sear;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private ComboBox cb_stat;
        private DateTimePicker dtp_app;
        private ComboBox cb_patie;
        private ComboBox cb_doc;
        private DataGridView dgv_appo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}