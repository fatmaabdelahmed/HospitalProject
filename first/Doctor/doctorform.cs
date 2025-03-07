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
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace first.Doctor
{

    public partial class doctorform : Form
    {
        //private readonly HOSPITALDbContext _context;
        private readonly DbConnection con;

        int d_id;

        public doctorform(int doctor_id)
        {
            InitializeComponent();
            HOSPITALDbContext db = new HOSPITALDbContext();
            con = db.Database.GetDbConnection();
            d_id = doctor_id;
        }
        private void doctorform_Load(object sender, EventArgs e)
        {
            get_doctor_profile_data();
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Doctor Info Tab
                    get_doctor_profile_data();
                    break;

                case 1: // Appointments Tab
                    load_doctor_appointments();
                    break;

                case 2: // Patients Tab
                    get_medical_record();
                    break;
            }
        }


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
        private void load_doctor_appointments()
        {

            string query1 = $"select a.AppointmentId,a.AppointmentDate,a.PatientId,a.Status,a.DoctorId, p.Name as PatientName from Appointments  a join Patients p on p.PatientId=a.PatientId where  a.DoctorId={d_id}";
            var q1 = con.Query<Appointment, Patient, Appointment>(
                query1,
                (a, p) =>
                {
                    // a.Doctor = new doctor { Name = d.Name };
                    a.Patient = new Patient { Name = p.Name };
                    return a;
                },
                splitOn: "PatientName"
            ).ToList();

            dgv_appoinments.DataSource = q1;



        }
        //private void update_doctor_profile()
        //{
        //    string query3 = "select d.Name ,d.Schedule ,d.Specialization,d.ContactInfo ,u.PasswordHash from Doctors d join Users u on u.UserId=d.UsersmemberId where DoctorId=@DoctorId";
        //    var parameters1 = new { DoctorId = d_id };


        //    var doctor = con.QueryFirstOrDefault<doctor, User, doctor>(query3, (doc, user) =>
        //    {

        //    }


        //        , parameters1);
        //    string oldpass =doctor.pas;
        //    if (txt_oldpass_profile.Text != oldpass)
        //    {
        //        MessageBox.Show(" old Password is incorrect");
        //        return;
        //    }

        //    if (txt_newpass_profile.Text != txt_conpass_profile.Text)
        //    {
        //        MessageBox.Show("Passwords do not match");
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(txt_name_profile.Text) || string.IsNullOrWhiteSpace(txt_newpass_profile.Text) ||
        //         string.IsNullOrWhiteSpace(txt_conpass_profile.Text))|| string.IsNullOrWhiteSpace(txt_newpass_profile.Text)
        //    {
        //        MessageBox.Show("All fields are required.");
        //        return;
        //    }

        //    string query = @"UPDATE Doctors 
        //             SET Name = @Name, 
        //                 Schedule = @Schedule, 
        //                 Specialization = @Specialization, 
        //                 ContactInfo = @ContactInfo 
        //             WHERE DoctorId = @DoctorId";

        //    var parameters = new
        //    {
        //        Name = txt_name_profile.Text,
        //        Schedule = txt_sched_profile.Text,
        //        Specialization = txt_speci_profile.Text,
        //        ContactInfo = txt_con_profile.Text,
        //        DoctorId = d_id
        //    };
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

        //////////////////////////////////////////////////////////////////////////////
        /////////////////////////////medical record///////////////////////////////////////////////

        private void get_all_patients()
        {
            string qurey4 = "select p.PatientId,p.Name from Patients p";
            var patients = con.Query<Patient>(qurey4).ToList();
            com_paiens_name_medrec.DataSource = patients;

            com_paiens_name_medrec.ValueMember = "PatientId";
            com_paiens_name_medrec.DisplayMember = "Name";

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
                if (com_paiens_name_medrec.SelectedValue != null && int.TryParse(com_paiens_name_medrec.SelectedValue.ToString(), out  patientId))
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
        }

        private void btn_add_medirec_Click(object sender, EventArgs e)
        {
            try {

                string query7 = "INSERT INTO MedicalRecords (PatientId, DoctorId, Diagnosis, Prescription, TreatmentPlan, RecordDate)  VALUES (@PatientId, @DoctorId, @Diagnosis, @Prescription, @TreatmentHistory,GETDATE())";
                var prameters7 = new
                {
                    PatientId = patientId,
                    DoctorId = d_id,
                    Diagnosis = txt_diag_medicrec.Text,
                    Prescription = txt_presc_medicrec.Text,
                    TreatmentHistory = txt_treatment_medicrec.Text,
                };

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
    }
}
