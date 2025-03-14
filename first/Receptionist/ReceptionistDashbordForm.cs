using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using first.Doctor;
using first.models;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace first.Receptionist
{
    public partial class ReceptionistDashbordForm : Form
    {
        IDbConnection con;
        public ReceptionistDashbordForm()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=hospitalManageDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public ReceptionistDashbordForm(int userId)
        {
            this.userId = userId;
        }

        private void patientload()
        {
            var patientcb = con.Query<Patient>("select PatientId ,Name from Patients").ToList();
            cb_patie.DataSource = patientcb;
            cb_patie.DisplayMember = "Name";
            cb_patie.ValueMember = "PatientId";
        }

        private void docload()
        {
            var doc = con.Query("select DoctorId ,Name from Doctors").ToList();
            cb_doc.DataSource = doc;
            cb_doc.DisplayMember = "Name";
            cb_doc.ValueMember = "DoctorId";

        }
        private void LoadStatusComboBox()
        {
            cb_stat.DataSource = Enum.GetValues(typeof(AppointmentStatus))
                                      .Cast<AppointmentStatus>()
                                      .Select(x => new { Value = (int)x, Text = x.ToString() })
                                      .ToList();

            cb_stat.DisplayMember = "Text";
            cb_stat.ValueMember = "Value";
        }

        private void loadappointment()
        {
            var appointments = con.Query(
         ReceptionistServices.Getallappointment).Select(a => new
         {
             AppointmentId = a.AppointmentId,
             AppointmentDate = a.AppointmentDate,
             Status = ((AppointmentStatus)a.Status).ToString(),
             PatientId = a.PatientId,
             PatientName = a.PatientName,
             DoctorId = a.DoctorId,
             DoctorName = a.DoctorName
         }).ToList();

            dgv_appo.DataSource = appointments;
        }

        private bool IsValidAppointment(int doctorId, DateTime appointmentDate, int? currentAppointmentId = null)
        {
            if (appointmentDate < DateTime.Now)
            {
                MessageBox.Show("Cannot schedule an appointment in the past!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int count = con.ExecuteScalar<int>(@"
        SELECT COUNT(*) 
        FROM Appointments 
        WHERE DoctorId = @DoctorId 
        AND ABS(DATEDIFF(MINUTE, AppointmentDate, @AppointmentDate)) < 30
        AND (@CurrentAppointmentId IS NULL OR AppointmentId <> @CurrentAppointmentId);
    ", new { doctorId, appointmentDate, currentAppointmentId });

            if (count > 0)
            {
                MessageBox.Show("The selected appointment time is already booked!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



        private async void  ReceptionistDashbordForm_Load(object sender, EventArgs e)
        {
       

            docload();
            patientload();
            LoadStatusComboBox();
            loadappointment();
            try
            {
                await AppointmentReminder.StartReminderServiceAsync();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ أثناء تشغيل التذكيرات: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
        int appoint_id;
        private int userId;

        private void dgv_appo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            cb_doc.SelectedValue = dgv_appo.SelectedRows[0].Cells["DoctorId"].Value;
            cb_patie.SelectedValue = dgv_appo.SelectedRows[0].Cells["PatientId"].Value;
            cb_stat.SelectedValue = (int)Enum.Parse(typeof(AppointmentStatus), dgv_appo.SelectedRows[0].Cells["Status"].Value.ToString());
            dtp_app.Value = Convert.ToDateTime(dgv_appo.SelectedRows[0].Cells["AppointmentDate"].Value);

            appoint_id = (int)dgv_appo.SelectedRows[0].Cells["AppointmentId"].Value;



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int patientId = (int)cb_patie.SelectedValue;
            int doctorId = (int)cb_doc.SelectedValue;
            int status = (int)cb_stat.SelectedValue;
            DateTime appointmentDate = dtp_app.Value;

            if (!IsValidAppointment(doctorId, appointmentDate))
            {
                return;
            }
            var enterpat = con.Execute(ReceptionistServices.AddAppointment, new { patientId, doctorId, appointmentDate, status });
            MessageBox.Show(" the appointment is added!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadappointment();





        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_appo.SelectedRows.Count > 0)
            {


                if (cb_patie.SelectedValue == null || cb_patie.DataSource == null)
                {
                    MessageBox.Show("Please select a valid patient!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cb_doc.SelectedValue == null || cb_doc.DataSource == null)
                {
                    MessageBox.Show("Please select a valid doctor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int patientId = (int)cb_patie.SelectedValue;
                int doctorId = (int)cb_doc.SelectedValue;
                int status = (int)cb_stat.SelectedValue;
                DateTime appointmentDate = dtp_app.Value;
                DateTime currentAppointmentDate = con.QuerySingle<DateTime>(
     "SELECT AppointmentDate FROM Appointments WHERE AppointmentId = @AppointmentId",
     new { AppointmentId = appoint_id });

                if (currentAppointmentDate != appointmentDate && !IsValidAppointment(doctorId, appointmentDate, appoint_id))
                {
                    return;
                }



                var editapp = con.Execute(ReceptionistServices.EditAppointment, new { patientId, doctorId, appointmentDate, status, AppointmentId = appoint_id });
                MessageBox.Show(" the appointment is updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadappointment();





            }
            else
            {

                MessageBox.Show("select an row to update", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_appo.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.No)
                {
                    return;
                }
                con.Execute(ReceptionistServices.DeleteAppointment, new { AppointmentId = appoint_id });
                MessageBox.Show(" the appointment is deleted!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadappointment();

            }
            else
            {
                MessageBox.Show("select an row to delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_sear_Click(object sender, EventArgs e)
        {
            string searchInput = txt_serch.Text.Trim();

            // تعريف المتغيرات الافتراضية للبحث
            DateTime? appointmentDate = null;
            string patientName = null;
            string doctorName = null;

            // محاولة تحويل المدخل إلى تاريخ
            if (DateTime.TryParse(searchInput, out DateTime parsedDate))
            {
                appointmentDate = parsedDate;
            }
            else
            {
                // إذا لم يكن تاريخًا، افترض أنه اسم مريض أو طبيب
                patientName = searchInput;
                doctorName = searchInput;
            }

            // تنفيذ الاستعلام وتمرير القيم الصحيحة
            var searchResults = con.Query<dynamic>(
            ReceptionistServices.SearchAppointmentsByDate,
            new
            {
                AppointmentDate = appointmentDate,
                PatientName = patientName,
                DoctorName = doctorName
            }
        ).Select(a => new
        {
            AppointmentId = (int?)a.AppointmentId,  // `int?` يسمح بـ null
            AppointmentDate = (DateTime?)a.AppointmentDate ?? DateTime.MinValue,
            Status = ((AppointmentStatus)(int?)(a.Status ?? 0)).ToString(),
            PatientName = a.PatientName?.ToString() ?? "Unknown",
            DoctorName = a.DoctorName?.ToString() ?? "Unknown"
        }).ToList();

            // عرض النتائج في DataGridView
            dgv_appo.DataSource = searchResults;
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.OfType<PatientManagementForm>().Any())
            {
                panel3.Controls.Clear();
                PatientManagementForm form = new PatientManagementForm();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                panel3.Controls.Add(form);
                form.Show();
            }
        }

        private void btn_appoint_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Appointmentform form = new Appointmentform();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(form);
            form.Show();

        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            BillingManagementForm form = new BillingManagementForm();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(form);
            form.Show();
        }


        private void btn_profile_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
          
            EditProfileForm form = new EditProfileForm(1005);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(form);
            form.Show();
        }
    }
}
