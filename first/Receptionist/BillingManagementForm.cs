using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Dapper;
using first.models;

namespace first.Receptionist
{
    public partial class BillingManagementForm : Form
    {
        IDbConnection con;
        public BillingManagementForm()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=hospitalManageDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        private void loaddgv()
        {
            var bills = con.Query<dynamic>(ReceptionistServices.GetAllBills).Select(b => new
            {
                AppointmentId = b.AppointmentId,
                PatientId = b.PatientId,
                PatientName = b.PatientName,
                DoctorName = b.DoctorName,
                TotalAmount = b.TotalAmount,
                PaidAmount = b.PaidAmount,
                OutstandingBalance = b.OutstandingBalance,
                PaymentStatus = ((PaymentStatus)b.PaymentStatus).ToString(),
                PaymentDate = b.PaymentDate?.ToString("yyyy-MM-dd") ?? "N/A"
            }).ToList();

            dgv_billing.DataSource = bills;
        }

        private void BillingManagementForm_Load(object sender, EventArgs e)
        {
            loaddgv();

            var query = @"
        SELECT 
            a.AppointmentId, 
            a.PatientId, 
            CONCAT(p.Name, ' - ', d.Name, ' - ', FORMAT(a.AppointmentDate, 'yyyy-MM-dd HH:mm')) AS AppointmentInfo 
        FROM Appointments a
        JOIN Patients p ON a.PatientId = p.PatientId
        JOIN Doctors d ON a.DoctorId = d.DoctorId;";

            var appointments = con.Query(query).Select(a => new
            {
                AppointmentId = (int)a.AppointmentId,
                PatientId = (int)a.PatientId,
                AppointmentInfo = (string)a.AppointmentInfo
            }).ToList();

            cb_appoint_billing.DataSource = appointments;
            cb_appoint_billing.DisplayMember = "AppointmentInfo";
            cb_appoint_billing.ValueMember = "AppointmentId";
            cb_appoint_billing.Tag = appointments.ToDictionary(a => a.AppointmentId, a => a.PatientId);

            cb_status_pay.DataSource = Enum.GetValues(typeof(PaymentStatus))
                                         .Cast<PaymentStatus>()
                                         .Select(x => new { Value = (int)x, Text = x.ToString() })
                                         .ToList();

            cb_status_pay.DisplayMember = "Text";
            cb_status_pay.ValueMember = "Value";
            cb_status_pay.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_appoint_billing.SelectedItem == null)
            {
                MessageBox.Show("Please select an appointment before adding the bill.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_total.Text, out decimal totalAmount) ||
                !decimal.TryParse(txt_paid.Text, out decimal paidAmount))
            {
                MessageBox.Show("Please enter valid values for total amount and paid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedAppointmentId = (int)cb_appoint_billing.SelectedValue;
            int patientId = ((Dictionary<int, int>)cb_appoint_billing.Tag)[selectedAppointmentId];

            var existingBill = con.QueryFirstOrDefault<Billing>(
                "SELECT * FROM Billings WHERE AppointmentId = @AppointmentId",
                new { AppointmentId = selectedAppointmentId });

            if (existingBill != null)
            {
                MessageBox.Show("This bill already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var Status = paidAmount >= totalAmount ? PaymentStatus.Paid : PaymentStatus.Pending;

                var count = con.Execute(ReceptionistServices.AddBill, new
                {
                    AppointmentId = selectedAppointmentId,
                    PatientId = patientId,
                    TotalAmount = totalAmount,
                    PaidAmount = paidAmount,
                    PaymentStatus = (int)Status,
                    PaymentDate = dtp_date.Value
                });

                if (count > 0)
                {
                    MessageBox.Show($"Bill added successfully:\n\nTotal Amount: {totalAmount}\nPaid Amount: {paidAmount}\nPayment Status: {Status}",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgv();
                }
                else
                {
                    MessageBox.Show("Failed to add the bill, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_total.Text, out decimal totalAmount) ||
                !decimal.TryParse(txt_paid.Text, out decimal paidAmount))
            {
                MessageBox.Show("Please enter valid values for total amount and paid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedAppointmentId = (int)cb_appoint_billing.SelectedValue;
            int patientId = ((Dictionary<int, int>)cb_appoint_billing.Tag)[selectedAppointmentId];
            var Status = paidAmount >= totalAmount ? PaymentStatus.Paid : PaymentStatus.Pending;

            var count = con.Execute(ReceptionistServices.EditBill, new
            {
                AppointmentId = appo,
                TotalAmount = totalAmount,
                PaidAmount = paidAmount,
                PaymentStatus = (int)Status,
                PaymentDate = dtp_date.Value
            });

            if (count > 0)
            {
                MessageBox.Show($"Bill updated successfully:\n\nTotal Amount: {totalAmount}\nPaid Amount: {paidAmount}\nPayment Status: {Status}",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgv();
            }
            else
            {
                MessageBox.Show("Failed to update the bill, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int appo;
        private void dgv_billing_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cb_appoint_billing.SelectedValue = (int)dgv_billing.SelectedRows[0].Cells["AppointmentId"].Value;
            txt_total.Text = Convert.ToString(dgv_billing.SelectedRows[0].Cells["TotalAmount"].Value);
            txt_paid.Text = Convert.ToString(dgv_billing.SelectedRows[0].Cells["PaidAmount"].Value);
            dtp_date.Value = Convert.ToDateTime(dgv_billing.SelectedRows[0].Cells["PaymentDate"].Value);
            appo = (int)dgv_billing.SelectedRows[0].Cells["AppointmentId"].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Execute(ReceptionistServices.DeleteBill, new
            {
                AppointmentId = appo
            });
            loaddgv();
        }
    }
}
