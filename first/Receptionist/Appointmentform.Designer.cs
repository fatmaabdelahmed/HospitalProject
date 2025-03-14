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
            panel3 = new Panel();
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
            panel3.Location = new Point(56, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1066, 733);
            panel3.TabIndex = 3;
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
            btn_sear.Location = new Point(799, 17);
            btn_sear.Name = "btn_sear";
            btn_sear.Size = new Size(160, 50);
            btn_sear.TabIndex = 8;
            btn_sear.Text = "Search";
            btn_sear.UseVisualStyleBackColor = true;
            btn_sear.Click += btn_sear_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(814, 620);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(160, 50);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(814, 538);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(160, 50);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(814, 471);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(160, 50);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cb_stat
            // 
            cb_stat.FormattingEnabled = true;
            cb_stat.Location = new Point(799, 248);
            cb_stat.Name = "cb_stat";
            cb_stat.Size = new Size(151, 28);
            cb_stat.TabIndex = 4;
            // 
            // dtp_app
            // 
            dtp_app.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_app.Format = DateTimePickerFormat.Custom;
            dtp_app.Location = new Point(799, 198);
            dtp_app.Name = "dtp_app";
            dtp_app.ShowUpDown = true;
            dtp_app.Size = new Size(240, 27);
            dtp_app.TabIndex = 3;
            // 
            // cb_patie
            // 
            cb_patie.FormattingEnabled = true;
            cb_patie.Location = new Point(799, 150);
            cb_patie.Name = "cb_patie";
            cb_patie.Size = new Size(151, 28);
            cb_patie.TabIndex = 2;
            // 
            // cb_doc
            // 
            cb_doc.FormattingEnabled = true;
            cb_doc.Location = new Point(799, 93);
            cb_doc.Name = "cb_doc";
            cb_doc.Size = new Size(151, 28);
            cb_doc.TabIndex = 1;
            // 
            // dgv_appo
            // 
            dgv_appo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            ClientSize = new Size(1313, 833);
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
    }
}