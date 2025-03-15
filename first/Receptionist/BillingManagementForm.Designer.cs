namespace first.Receptionist
{
    partial class BillingManagementForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_paid = new TextBox();
            txt_total = new TextBox();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            dgv_billing = new DataGridView();
            cb_appoint_billing = new ComboBox();
            cb_status_pay = new ComboBox();
            dtp_date = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_billing).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 116, 192);
            label5.Location = new Point(724, 248);
            label5.Name = "label5";
            label5.Size = new Size(65, 22);
            label5.TabIndex = 43;
            label5.Text = "status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(64, 116, 192);
            label4.Location = new Point(718, 209);
            label4.Name = "label4";
            label4.Size = new Size(125, 22);
            label4.TabIndex = 42;
            label4.Text = "appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 116, 192);
            label2.Location = new Point(718, 116);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 39;
            label2.Text = "paidAmount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 116, 192);
            label1.Location = new Point(717, 68);
            label1.Name = "label1";
            label1.Size = new Size(126, 22);
            label1.TabIndex = 38;
            label1.Text = "TotalAmount";
            // 
            // txt_paid
            // 
            txt_paid.ForeColor = Color.FromArgb(64, 116, 192);
            txt_paid.Location = new Point(863, 116);
            txt_paid.Name = "txt_paid";
            txt_paid.Size = new Size(173, 27);
            txt_paid.TabIndex = 37;
            // 
            // txt_total
            // 
            txt_total.ForeColor = Color.FromArgb(64, 116, 192);
            txt_total.Location = new Point(863, 68);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(173, 27);
            txt_total.TabIndex = 36;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(64, 116, 192);
            btn_delete.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(794, 603);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(207, 50);
            btn_delete.TabIndex = 33;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(64, 116, 192);
            btn_edit.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(794, 521);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(207, 50);
            btn_edit.TabIndex = 32;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(64, 116, 192);
            btn_add.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(794, 454);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(207, 50);
            btn_add.TabIndex = 31;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dgv_billing
            // 
            dgv_billing.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 116, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_billing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_billing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 116, 192);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_billing.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_billing.EnableHeadersVisualStyles = false;
            dgv_billing.Location = new Point(12, 12);
            dgv_billing.Name = "dgv_billing";
            dgv_billing.RowHeadersWidth = 51;
            dgv_billing.Size = new Size(699, 652);
            dgv_billing.TabIndex = 28;
            dgv_billing.RowHeaderMouseDoubleClick += dgv_billing_RowHeaderMouseDoubleClick;
            // 
            // cb_appoint_billing
            // 
            cb_appoint_billing.ForeColor = Color.FromArgb(64, 116, 192);
            cb_appoint_billing.FormattingEnabled = true;
            cb_appoint_billing.Location = new Point(863, 209);
            cb_appoint_billing.Name = "cb_appoint_billing";
            cb_appoint_billing.Size = new Size(173, 28);
            cb_appoint_billing.TabIndex = 44;
            // 
            // cb_status_pay
            // 
            cb_status_pay.ForeColor = Color.FromArgb(64, 116, 192);
            cb_status_pay.FormattingEnabled = true;
            cb_status_pay.Location = new Point(863, 248);
            cb_status_pay.Name = "cb_status_pay";
            cb_status_pay.Size = new Size(173, 28);
            cb_status_pay.TabIndex = 45;
            // 
            // dtp_date
            // 
            dtp_date.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            dtp_date.Location = new Point(863, 166);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(173, 26);
            dtp_date.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 116, 192);
            label3.Location = new Point(724, 166);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 47;
            label3.Text = "bill date";
            // 
            // BillingManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1083, 669);
            Controls.Add(label3);
            Controls.Add(dtp_date);
            Controls.Add(cb_status_pay);
            Controls.Add(cb_appoint_billing);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_paid);
            Controls.Add(txt_total);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(dgv_billing);
            Name = "BillingManagementForm";
            Text = "BillingManagementForm";
            Load += BillingManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_billing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox txt_medical;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_paid;
        private TextBox txt_total;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private ComboBox cb_gen;
        private DataGridView dgv_billing;
        private ComboBox cb_appoint_billing;
        private ComboBox cb_status_pay;
        private ComboBox comboBox3;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dtp_date;
    }
}