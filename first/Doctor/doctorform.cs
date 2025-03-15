using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using first.models;

using first.Login;
using first.Receptionist;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace first.Doctor
{

    public partial class doctorform : Form
    {

        private readonly DbConnection con;

        int d_id;
        private bool formLoaded = false;
        public doctorform(int doctor_id)
        {
            InitializeComponent();
            HOSPITALDbContext db = new HOSPITALDbContext();
            con = db.Database.GetDbConnection();
            d_id = doctor_id;
        }

        #region form_load
        private void doctorform_Load(object sender, EventArgs e)
        {
            get_doctor_profile_data();
            HideTab();

            get_all_appointment_status();
            formLoaded = true;
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Doctor Info Tab
                    get_doctor_profile_data();
                    HideTab();

                    break;

                case 1: // Appointments Tab
                    load_doctor_appointments();
                    // get_all_appointment_status();

                    HideTab();
                    break;

                case 2: // Patients Tab
                    get_medical_record();
                    HideTab();
                    break;

            }
        }

        #endregion




        #region profile
        private void get_doctor_profile_data()
        {

            string query2 = "SELECT d.Name , d.Schedule, d.Specialization, d.ContactInfo FROM Doctors d WHERE DoctorId = @DoctorId";


            var parameters = new { DoctorId = d_id };


            var doctor = con.QueryFirstOrDefault<doctor>(query2, parameters);


            if (doctor != null)
            {

                txt_name_profile.Text = (string)doctor.Name;
                txt_sched_profile.Text = doctor.Schedule;
                txt_speci_profile.Text = doctor.Specialization;
                txt_con_profile.Text = doctor.ContactInfo;
            }
            else
            {

                MessageBox.Show("Doctor not found!");
            }
        }
        //private void load_doctor_appointments()
        //{

        //    string query1 = $"select a.AppointmentId,a.AppointmentDate,a.PatientId,a.Status,a.DoctorId, p.Name as PatientName from Appointments  a join Patients p on p.PatientId=a.PatientId where  a.DoctorId={d_id}";
        //    var q1 = con.Query<Appointment, Patient, Appointment>(
        //        query1,
        //        (a, p) =>
        //        {
        //            // a.Doctor = new doctor { Name = d.Name };
        //            a.Patient = new Patient { Name = p.Name };
        //            return a;
        //        },
        //        splitOn: "PatientName"
        //    ).ToList();

        //    dgv_appoinments.DataSource = q1;



        //}

        private void update_doctor_profile()
        {
            try
            {

                string query3 = @"
            SELECT d.Name, d.Schedule, d.Specialization, d.ContactInfo, u.PasswordHash 
            FROM Doctors d 
            JOIN Users u ON u.UserId = d.UsersmemberId 
            WHERE DoctorId = @DoctorId";

                var parameters1 = new { DoctorId = d_id };


                var result = con.Query<doctor, Usersmember, doctor>(
                    query3,
                    (d, u) =>
                    {
                        d.Usersmember = new Usersmember { PasswordHash = u.PasswordHash };
                        return d;
                    },
                    parameters1,
                    splitOn: "PasswordHash"
                ).ToList();

                if (result == null)
                {
                    MessageBox.Show("Doctor not found!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_name_profile.Text) ||
                        string.IsNullOrWhiteSpace(txt_newpass_profile.Text) ||
                          string.IsNullOrWhiteSpace(txt_oldpass_profile.Text) ||
                        string.IsNullOrWhiteSpace(txt_conpass_profile.Text))

                {
                    MessageBox.Show("All fields are required.");
                    return;
                }


                if (txt_oldpass_profile.Text != result.FirstOrDefault().Usersmember.PasswordHash)
                {
                    MessageBox.Show("Old password is incorrect.");
                    return;
                }


                if (txt_newpass_profile.Text != txt_conpass_profile.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                // Validate that all required fields are filled



                string updateQuery = @"
                        UPDATE Doctors 
                        SET Name = @Name, 
                            Schedule = @Schedule, 
                            Specialization = @Specialization, 
                            ContactInfo = @ContactInfo 
                        WHERE DoctorId = @DoctorId;

                        UPDATE Users 
                        SET PasswordHash = @PasswordHash, Username = @Name
                        WHERE UserId = (SELECT UsersmemberId FROM Doctors WHERE DoctorId = @DoctorId);";

                var parameters = new
                {
                    Name = txt_name_profile.Text,
                    Schedule = txt_sched_profile.Text,
                    Specialization = txt_speci_profile.Text,
                    ContactInfo = txt_con_profile.Text,
                    PasswordHash = txt_newpass_profile.Text,
                    DoctorId = d_id
                };

                con.Execute(updateQuery, parameters);
                MessageBox.Show("Profile updated successfully!");

                get_doctor_profile_data();
                txt_oldpass_profile.Text = txt_newpass_profile.Text = txt_conpass_profile.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void btn_update_profile_Click(object sender, EventArgs e)
        {
            update_doctor_profile();


        }



        #endregion





        #region medical record
        #region get_data_profile
        private void get_all_patients()
        {
            string qurey4 = "select p.PatientId,p.Name from Patients p";
            var patients = con.Query<Patient>(qurey4).ToList();
            com_paiens_name_medrec.DataSource = patients;

            com_paiens_name_medrec.ValueMember = "PatientId";
            com_paiens_name_medrec.DisplayMember = "Name";

        }
        private void get_all_doctors()
        {
            string qurey4 = "select d.DoctorId, d.Name from Doctors d";
            var doctors = con.Query<doctor>(qurey4).ToList();
            com_doctor.DataSource = doctors;

            com_doctor.ValueMember = "DoctorId";
            com_doctor.DisplayMember = "Name";

        }

        private void get_medical_record_by_doctor()
        {
            try
            {
                string query5 = "select * from MedicalRecords m where m.DoctorId =@DoctorId";
                var prameters5 = new
                {
                    DoctorId = d_id
                };
                var medicalrecords = con.Query<MedicalRecord>(query5, prameters5).ToList();
                dgv_medical_rec.DataSource = medicalrecords;
                dgv_medical_rec.Columns["DoctorId"].Visible = false;
                dgv_medical_rec.Columns["PatientId"].Visible = false;
                dgv_medical_rec.Columns["doctor"].Visible = false;
                dgv_medical_rec.Columns["RecordId"].Visible = false;
                dgv_medical_rec.Columns["Patient"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }



        }

        private void get_medical_record()
        {
            get_all_patients();
            get_medical_record_by_doctor();
        }
        #endregion
        #region event_medicalrecord
        int patientId;
        private void com_paiens_name_medrec_SelectedValueChanged(object sender, EventArgs e)
        {
            if (com_paiens_name_medrec.SelectedValue == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            try
            {
                if (com_paiens_name_medrec.SelectedValue != null && int.TryParse(com_paiens_name_medrec.SelectedValue.ToString(), out patientId))
                {
                    string query6 = "select * from MedicalRecords m where m.DoctorId =@DoctorId and m.PatientId=@PatientId";
                    var prameters6 = new
                    {
                        PatientId = patientId,
                        DoctorId = d_id
                    };

                    var medicalrecords = con.Query<MedicalRecord>(query6, prameters6).ToList();
                    dgv_medical_rec.DataSource = medicalrecords;

                    // Hide unnecessary columns
                    dgv_medical_rec.Columns["DoctorId"].Visible = false;
                    dgv_medical_rec.Columns["PatientId"].Visible = false;
                    dgv_medical_rec.Columns["doctor"].Visible = false;
                    dgv_medical_rec.Columns["RecordId"].Visible = false;
                    dgv_medical_rec.Columns["Patient"].Visible = false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private void clear()
        {
            txt_treatment_medicrec.Text = "";
            txt_presc_medicrec.Text = "";
            txt_diag_medicrec.Text = "";
            txt_report_medirec.Text = "";
            txt_lab_res_medirec.Text = "";
        }
        private void dgv_medical_rec_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                string columnName = dgv.Columns[e.ColumnIndex].Name;


                if (columnName == "LabResults" || columnName == "Report")
                {
                    string filePath = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private TabPage hiddenTab;

        private void HideTab()
        {
            if (tabControl1.TabPages.Contains(tabPage4))
            {
                hiddenTab = tabPage4; // Store the reference
                tabControl1.TabPages.Remove(tabPage4);
            }
        }


        private void com_doctor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (com_doctor.SelectedValue == null)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }

            try
            {
                if (com_doctor.SelectedValue != null && int.TryParse(com_doctor.SelectedValue.ToString(), out int docid))
                {
                    string query6 = "select * from MedicalRecords m where m.DoctorId =@DoctorId and m.PatientId=@PatientId";
                    var prameters6 = new
                    {
                        PatientId = patientId,
                        DoctorId = docid,
                    };

                    var medicalrecords = con.Query<MedicalRecord>(query6, prameters6).ToList();
                    dgv_get_all_medicalrecords.DataSource = medicalrecords;

                    // Hide unnecessary columns
                    dgv_get_all_medicalrecords.Columns["DoctorId"].Visible = false;
                    dgv_get_all_medicalrecords.Columns["PatientId"].Visible = false;
                    dgv_get_all_medicalrecords.Columns["doctor"].Visible = false;
                    dgv_get_all_medicalrecords.Columns["RecordId"].Visible = false;
                    dgv_get_all_medicalrecords.Columns["Patient"].Visible = false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        #endregion
        #region btn_profile
        private void btn_add_medirec_Click(object sender, EventArgs e)
        {
            try
            {

                string query7 = "INSERT INTO MedicalRecords (PatientId, DoctorId, Diagnosis, Prescription, TreatmentPlan, RecordDate,LabResults,Report)   VALUES (@PatientId, @DoctorId, @Diagnosis, @Prescription, @TreatmentHistory,GETDATE(),@labresult,@report)";
                var prameters7 = new
                {
                    PatientId = patientId,
                    DoctorId = d_id,
                    Diagnosis = txt_diag_medicrec.Text,
                    Prescription = txt_presc_medicrec.Text,
                    TreatmentHistory = txt_treatment_medicrec.Text,
                    labresult = txt_lab_res_medirec.Text,
                    report = txt_report_medirec.Text,
                };
                if (string.IsNullOrWhiteSpace(txt_diag_medicrec.Text) ||
                       string.IsNullOrWhiteSpace(txt_presc_medicrec.Text) ||
                         string.IsNullOrWhiteSpace(txt_treatment_medicrec.Text))


                {
                    MessageBox.Show("All fields are required.");
                    return;
                }
                con.Execute(query7, prameters7);

                string query6 = "select * from MedicalRecords m where m.DoctorId =@DoctorId and m.PatientId=@PatientId";
                var prameters6 = new
                {
                    PatientId = patientId,
                    DoctorId = d_id
                };

                var medicalrecords = con.Query<MedicalRecord>(query6, prameters6).ToList();
                dgv_medical_rec.DataSource = medicalrecords;

                // Hide unnecessary columns
                dgv_medical_rec.Columns["DoctorId"].Visible = false;
                dgv_medical_rec.Columns["PatientId"].Visible = false;
                dgv_medical_rec.Columns["doctor"].Visible = false;
                dgv_medical_rec.Columns["RecordId"].Visible = false;
                dgv_medical_rec.Columns["Patient"].Visible = false;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btn_browse_result_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    txt_lab_res_medirec.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_report_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    txt_report_medirec.Text = openFileDialog.FileName;
                }
            }

        }

        private void btn_allrec_Click(object sender, EventArgs e)
        {
            if (hiddenTab != null && !tabControl1.TabPages.Contains(tabPage4))
            {
                tabControl1.TabPages.Add(hiddenTab);
                tabControl1.SelectedTab = hiddenTab;
                hiddenTab = null;
            }
            get_all_doctors();
        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        #endregion

        #endregion





        #region appiontments
        private void load_doctor_appointments()
        {

            string query1 = $"select a.AppointmentId,a.AppointmentDate,a.PatientId,a.Status, p.Name as pationt,d.Name as doctor from Appointments  a join Patients p on p.PatientId=a.PatientId join Doctors d  on d.DoctorId =a.DoctorId where a.DoctorId={d_id}";


            var appointments = con.Query(
                query1).Select(a => new
                {
                    AppointmentId = a.AppointmentId,
                    AppointmentDate = a.AppointmentDate,
                    Status = ((AppointmentStatus)a.Status).ToString(),
                    PatientId = a.PatientId,

                    PatientName = (string)a.pationt,

                }).ToList();

            dgv_appoinments.DataSource = appointments;




        }
        #region btn_appointments
        private void btn_uppcoming_Click(object sender, EventArgs e)
        {
            string query1 = $"select a.AppointmentId,a.AppointmentDate,a.PatientId,a.Status, p.Name as pationt,d.Name as doctor from Appointments  a join Patients p on p.PatientId=a.PatientId join Doctors d  on d.DoctorId =a.DoctorId where a.DoctorId={d_id} and a.Status=0";

            var appointments = con.Query(
                query1).Select(a => new
                {
                    AppointmentId = a.AppointmentId,
                    AppointmentDate = a.AppointmentDate,
                    Status = ((AppointmentStatus)a.Status).ToString(),
                    PatientId = a.PatientId,

                    PatientName = (string)a.pationt,

                }).ToList();

            dgv_appoinments.DataSource = appointments;
        }

        private void btn_all_appintment_Click(object sender, EventArgs e)
        {
            load_doctor_appointments();
        }
        #endregion

        #region Appointment Status Methods

        private void get_all_appointment_status()
        {
            var statusList = new List<object>();
            foreach (AppointmentStatus status in Enum.GetValues(typeof(AppointmentStatus)))
            {
                // Exclude "Scheduled" status
                if (status != AppointmentStatus.Scheduled)
                {
                    statusList.Add(new { Value = (int)status, Display = status.ToString() });
                }
            }

            com_status.DataSource = statusList;
            com_status.ValueMember = "Value";
            com_status.DisplayMember = "Display";
        }

        #endregion


        #region events_apointment
        int appointmentId = -1;

        private void dgv_appoinments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgv_appoinments.Columns[e.ColumnIndex].Name;

                if (columnName == "Status")
                {
                    int rowIndex = e.RowIndex;


                    var cellValue = dgv_appoinments.Rows[rowIndex].Cells["AppointmentId"].Value;
                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                    {
                        appointmentId = id;
                    }
                    else
                    {
                        MessageBox.Show("Invalid appointment selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        private void com_status_SelectedValueChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                if (appointmentId == -1)
                {
                    MessageBox.Show("Please select an appointment before changing the status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (com_status.SelectedValue == null)
                {
                    MessageBox.Show("Invalid status selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int new_status;
                if (!int.TryParse(com_status.SelectedValue.ToString(), out new_status))
                {
                    MessageBox.Show("Invalid status value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "UPDATE Appointments SET Status = @Statusv WHERE AppointmentId = @AppointmentId";

                try
                {
                    ///MessageBox.Show($"Selected Value: {com_status.SelectedValue}");

                    con.Execute(query, new { Statusv = new_status, AppointmentId = appointmentId });
                    load_doctor_appointments();
                    MessageBox.Show("Appointment status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    appointmentId = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating appointment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion



        #endregion


        #region gui

        private void pic_bake_medical_rec_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            loginForm.Show();


            this.Hide();
        }

        private void pic_old_pass_Click(object sender, EventArgs e)
        {
            txt_oldpass_profile.UseSystemPasswordChar = !txt_oldpass_profile.UseSystemPasswordChar;
        }

        private void pict_new_pass_Click(object sender, EventArgs e)
        {
            txt_newpass_profile.UseSystemPasswordChar = !txt_newpass_profile.UseSystemPasswordChar;
        }

        private void pic_confirm_pass_Click(object sender, EventArgs e)
        {
            txt_conpass_profile.UseSystemPasswordChar = !txt_conpass_profile.UseSystemPasswordChar;
        }

        #endregion
    }
}
