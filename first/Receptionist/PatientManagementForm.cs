using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using first.models;
using Microsoft.Data.SqlClient;

namespace first.Receptionist
{
    public partial class PatientManagementForm : Form
    {
        IDbConnection con;

        public PatientManagementForm()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=hospitalManageDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        private void loadpa()
        {

            var patients = con.Query<Patient>("SELECT * FROM Patients").ToList();
            dgv_patient.DataSource = patients;
        }

        private void PatientManagementForm_Load(object sender, EventArgs e)
        {
            loadpa();
            cb_gen.DataSource = Enum.GetValues(typeof(Gender))
                                      .Cast<Gender>()
                                      .Select(x => new { Value = (int)x, Text = x.ToString() })
                                      .ToList();

            cb_gen.DisplayMember = "Text";
            cb_gen.ValueMember = "Value";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            DateTime dat = dt_patient.Value;
            int gender = (int)cb_gen.SelectedValue;
            string info = txt_contact.Text;
            string medicalhistory = txt_medical.Text;

            con.Execute(ReceptionistServices.AddPatient, new
            {
                Name = name,
                DateOfBirth = dat, // تأكدي من إرسال القيمة
                Gender = gender,
                ContactInfo = info,
                MedicalHistory = medicalhistory
            });
            MessageBox.Show(" the patient is added!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadpa();
        }
        int patid;
        private void dgv_patient_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patid = (int)dgv_patient.SelectedRows[0].Cells["PatientId"].Value;
            txt_name.Text = dgv_patient.SelectedRows[0].Cells["Name"].Value.ToString();
            txt_contact.Text = dgv_patient.SelectedRows[0].Cells["ContactInfo"].Value.ToString();
            dt_patient.Value = Convert.ToDateTime(dgv_patient.SelectedRows[0].Cells["DateOfBirth"].Value);
            txt_medical.Text = dgv_patient.SelectedRows[0].Cells["MedicalHistory"].Value.ToString();
            cb_gen.SelectedValue = (int)Enum.Parse(typeof(Gender), dgv_patient.SelectedRows[0].Cells["Gender"].Value.ToString());

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_patient.SelectedRows.Count > 0)
            {
                string name = txt_name.Text;
                DateTime dat = dt_patient.Value;
                int gender = (int)cb_gen.SelectedValue;
                string info = txt_contact.Text;
                string medicalhistory = txt_medical.Text;

                con.Execute(ReceptionistServices.EditPatient, new
                {
                    Name = name,
                    DateOfBirth = dat,
                    Gender = gender,
                    ContactInfo = info,
                    MedicalHistory = medicalhistory,
                    PatientId = patid
                });
                MessageBox.Show(" the patient is updated !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadpa();

            }
            else
            {
                MessageBox.Show("plaese select patient to edit !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_patient.SelectedRows.Count > 0)
            {
                con.Execute(ReceptionistServices.DeletePatient, new { PatientId = patid });
                MessageBox.Show(" the patient is deleted !", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadpa();
            }
            else
            {
                MessageBox.Show("plaese select patient to deleted !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_sear_pat_Click(object sender, EventArgs e)
        { 

            string info = txt_serchpat.Text.Trim();
            string name = txt_serchpat.Text.Trim();
            int? id = null; // اجعل id قابلاً لأن يكون null

            if (int.TryParse(txt_serchpat.Text, out int parsedId))
            {
                id = parsedId; // إذا كان الإدخال رقمًا، خزّنه في id
            }

            var searchresult = con.Query<Patient>(ReceptionistServices.SearchPatientByName, new
            {
                ContactInfo = info,
                Name = name,
                PatientId = id // لا تحوّله إلى int إذا كان null
            }).ToList();

            dgv_patient.DataSource = searchresult;
        }
    }
}


