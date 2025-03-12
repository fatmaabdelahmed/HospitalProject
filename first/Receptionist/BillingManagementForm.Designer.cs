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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgv_billing).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(761, 329);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 43;
            label5.Text = "status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(754, 293);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 42;
            label4.Text = "appointment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(761, 181);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 40;
            label3.Text = "Outstanding balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(761, 117);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 39;
            label2.Text = "paidAmount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(782, 68);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 38;
            label1.Text = "TotalAmount";
            // 
            // txt_paid
            // 
            txt_paid.Location = new Point(895, 117);
            txt_paid.Name = "txt_paid";
            txt_paid.Size = new Size(125, 27);
            txt_paid.TabIndex = 37;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(897, 68);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(125, 27);
            txt_total.TabIndex = 36;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(809, 604);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(160, 50);
            btn_delete.TabIndex = 33;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(809, 522);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(160, 50);
            btn_edit.TabIndex = 32;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(809, 455);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(160, 50);
            btn_add.TabIndex = 31;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dgv_billing
            // 
            dgv_billing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_billing.Location = new Point(13, 34);
            dgv_billing.Name = "dgv_billing";
            dgv_billing.RowHeadersWidth = 51;
            dgv_billing.Size = new Size(699, 652);
            dgv_billing.TabIndex = 28;
            dgv_billing.RowHeaderMouseDoubleClick += dgv_billing_RowHeaderMouseDoubleClick;
            // 
            // cb_appoint_billing
            // 
            cb_appoint_billing.FormattingEnabled = true;
            cb_appoint_billing.Location = new Point(869, 290);
            cb_appoint_billing.Name = "cb_appoint_billing";
            cb_appoint_billing.Size = new Size(151, 28);
            cb_appoint_billing.TabIndex = 44;
            // 
            // cb_status_pay
            // 
            cb_status_pay.FormattingEnabled = true;
            cb_status_pay.Location = new Point(869, 329);
            cb_status_pay.Name = "cb_status_pay";
            cb_status_pay.Size = new Size(151, 28);
            cb_status_pay.TabIndex = 45;
            // 
            // dtp_date
            // 
            dtp_date.Location = new Point(761, 246);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(250, 27);
            dtp_date.TabIndex = 46;
            // 
            // BillingManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 686);
            Controls.Add(dtp_date);
            Controls.Add(cb_status_pay);
            Controls.Add(cb_appoint_billing);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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