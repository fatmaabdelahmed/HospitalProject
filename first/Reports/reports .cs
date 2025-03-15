using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using first.models;
using Microsoft.EntityFrameworkCore;

using Excel = Microsoft.Office.Interop.Excel;
using first.Doctor;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;


using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

using first.Admin;
using first.Login;



namespace first.Reports
{
    public partial class reports : Form
    {
        private readonly DbConnection con;
        bool flag_load = false;
        public reports()
        {
            InitializeComponent();
            HOSPITALDbContext db = new HOSPITALDbContext();
            con = db.Database.GetDbConnection();

        }
        #region form_load
        private void reports_Load(object sender, EventArgs e)
        {
            GeneratePatientsPerDepartmentReport();
            get_all_patients();
            flag_load = true;
            //  GenerateAppointmentSchedulesReport();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Doctor Info Tab
                    GeneratePatientsPerDepartmentReport();
                    break;

                case 1: // Appointments Tab
                    GenerateAppointmentSchedulesReport();

                    break;

                case 2: // Patients Tab
                    GenerateOutstandingPaymentsReport();
                    break;
                case 3: // Patients Tab
                    GeneratePatientVisitHistory();
                    break;

            }
        }

        #endregion


        #region export to excel/pdf




        //private void ExportReportToExcel(DataGridView dgv)
        //    {
        //        try
        //        {
        //                // Set the license context (required for EPPlus 5+)
        //                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


        //                // Create a new Excel package
        //                using (var package = new ExcelPackage())
        //            {
        //                // Add a worksheet
        //                var worksheet = package.Workbook.Worksheets.Add("Report");

        //                // Write column headers
        //                for (int i = 0; i < dgv.Columns.Count; i++)
        //                {
        //                    // Set header text and apply bold formatting
        //                    worksheet.Cells[1, i + 1].Value = dgv.Columns[i].HeaderText;
        //                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
        //                }

        //                // Write row data
        //                for (int i = 0; i < dgv.Rows.Count; i++)
        //                {
        //                    if (dgv.Rows[i].IsNewRow)
        //                        continue; // Skip the new row placeholder

        //                    for (int j = 0; j < dgv.Columns.Count; j++)
        //                    {
        //                        object cellValue = dgv.Rows[i].Cells[j].Value;
        //                        worksheet.Cells[i + 2, j + 1].Value = cellValue != null ? cellValue.ToString() : "";
        //                    }
        //                }

        //                // Auto-fit columns for better readability
        //                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

        //                // Save the workbook to a file
        //                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Report.xlsx");
        //                package.SaveAs(new FileInfo(filePath));
        //            }

        //            MessageBox.Show("Report exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        private void ExportReportToExcel(DataGridView dgv)
        {
            try
            {
                // Base file name
                string baseFileName = "Report.xlsx";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), baseFileName);

                // Ensure the file name is unique
                int counter = 1;
                while (File.Exists(filePath))
                {
                    string fileName = $"Report_{counter}.xlsx";
                    filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
                    counter++;
                }

                // Rest of the code remains the same
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Report");

                    // Write column headers
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dgv.Columns[i].HeaderText;
                        worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                    }

                    // Write row data
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (dgv.Rows[i].IsNewRow)
                            continue;

                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            object cellValue = dgv.Rows[i].Cells[j].Value;
                            worksheet.Cells[i + 2, j + 1].Value = cellValue != null ? cellValue.ToString() : "";
                        }
                    }

                    // Auto-fit columns
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    // Save the workbook to a file
                    package.SaveAs(new FileInfo(filePath));

                    // Open the Excel file after saving
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }

                // MessageBox.Show("Report exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion


        #region GeneratePatientsPerDepartmentReport
        // Generate the patients per department report
        private void GeneratePatientsPerDepartmentReport()
        {
            string query = @"select d.Specialization as DepartmentName, COUNT(DISTINCT  p.PatientId) as PatientCount from Patients p 
	            join Appointments a   on p.PatientId =a.PatientId
	            join Doctors d on a.DoctorId=d.DoctorId
	            group by d.Specialization;";

            var no_patients_per_department = con.Query(query).ToList();


            dgv_reports.AutoGenerateColumns = false;



            #region Add columns manually
            dgv_reports.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DepartmentName",
                HeaderText = "Department Name"
            });

            dgv_reports.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PatientCount",
                HeaderText = "Patient Count"
            });

            #endregion


            dgv_reports.DataSource = no_patients_per_department;

        }
        // Export the patients per department report to Excel
        private void btn_patientNo_export_Click(object sender, EventArgs e)
        {
            ExportReportToExcel(dgv_reports);
        }
        #endregion




        #region GenerateAppointmentSchedulesReport
        // Generate the appointment schedules report
        private void GenerateAppointmentSchedulesReport()
        {
            string query = @"
        SELECT 
            a.AppointmentId,  a.PatientId,  a.Status,  p.Name AS PatientName,  d.Name AS DoctorName,
             FORMAT(a.AppointmentDate, 'dd/MM/yy') AS AppointmentDate,
            FORMAT(a.AppointmentDate, 'HH:mm:ss') AS AppointmentTime
            FROM Appointments a
            JOIN Patients p ON a.PatientId = p.PatientId
            JOIN Doctors d ON a.DoctorId = d.DoctorId
            ORDER BY a.AppointmentDate;";


            var appointments_SchedulesReport = con.Query(query)
                .Select(a => new
                {
                    AppointmentId = (int)a.AppointmentId,
                    AppointmentDate = (string)a.AppointmentDate,
                    AppointmentTime = (string)a.AppointmentTime,

                    Status = ((AppointmentStatus)(int)a.Status).ToString(),
                    PatientId = (int)a.PatientId,
                    PatientName = (string)a.PatientName,
                    DoctorName = (string)a.DoctorName
                })
                .ToList();

            dgv_appointment_schedules.AutoGenerateColumns = true;
            dgv_appointment_schedules.DataSource = appointments_SchedulesReport;


        }

        // Export the appointment schedules report to Excel
        private void btn_appoinment_export_Click(object sender, EventArgs e)
        {
            ExportReportToExcel(dgv_appointment_schedules);
        }
        #endregion



        #region GenerateOutstandingPaymentsReport
        // Generate the outstanding payments report
        private void GenerateOutstandingPaymentsReport()
        {

            string q = @"
              select
                    b.AppointmentId,  b.TotalAmount,  b.PaidAmount,  b.PaymentStatus,
                    FORMAT(b.PaymentDate, 'dd/MM/yy') AS billingDate,
                    FORMAT(b.PaymentDate, 'HH:mm:ss') AS billingTime,
                    p.Name AS PatientName, b.PatientId
              from Billings b
                join   Patients p ON p.PatientId = b.PatientId
               where  b.TotalAmount - b.PaidAmount != 0;";


            var OutstandingPayment = con.Query(q)
                .Select(a => new
                {
                    AppointmentId = (int)a.AppointmentId,
                    billingDate = (string)a.billingDate,
                    billingTime = (string)a.billingTime,
                    TotalAmount = (decimal)a.TotalAmount,
                    PaidAmount = (decimal)a.PaidAmount,
                    Status = ((PaymentStatus)(int)a.PaymentStatus).ToString(),
                    PatientId = (int)a.PatientId,
                    PatientName = (string)a.PatientName
                })
                .ToList();


            dgv_billing.AutoGenerateColumns = true;
            dgv_billing.DataSource = OutstandingPayment;
        }

        // Export the outstanding payments report to Excel
        private void btn_billing_Click(object sender, EventArgs e)
        {
            ExportReportToExcel(dgv_billing);
        }
        #endregion



        #region GeneratePatientVisitHistoryReport
        //get all patients to select from
        private void get_all_patients()
        {
            string qurey4 = "select p.PatientId,p.Name from Patients p";
            var patients = con.Query<Patient>(qurey4).ToList();
            com_patients.DataSource = patients;

            com_patients.ValueMember = "PatientId";
            com_patients.DisplayMember = "Name";

        }

        //generate visit history for specific patient
        private void GeneratePatientVisitHistoryReport(int p_id)
        {
            string query = @"select p.Name as patient_name ,
                 FORMAT(a.AppointmentDate, 'dd/MM/yy') AS AppointmentDate,
            FORMAT(a.AppointmentDate, 'HH:mm:ss') AS AppointmentTime,
                m.Diagnosis,m.TreatmentPlan ,d.Name as doctor_name  from Patients p 
                        join Appointments a on p.PatientId= a.PatientId 
                        join MedicalRecords m on p.PatientId=m.PatientId
                        join Doctors d on d.DoctorId=m.DoctorId
                        where  a.PatientId =@id ";
            var parameters = new { id = p_id };
            var PatientVisitHistory = con.Query(query, parameters)
                .Select(a => new
                {
                    PatientName = (string)a.patient_name,
                    AppointmentDate = (string)a.AppointmentDate,
                    AppointmentTime = (string)a.AppointmentTime,

                    Diagnosis = (string)a.Diagnosis,
                    TreatmentPlan = (string)a.TreatmentPlan,
                    DoctorName = (string)a.doctor_name
                })
                .ToList();


            dgv_patients.AutoGenerateColumns = true;
            dgv_patients.DataSource = PatientVisitHistory;

        }

        //generate all  visit history for all patients on load
        private void GeneratePatientVisitHistory()
        {
            string query = @"select p.Name as patient_name ,CONVERT(date, a.AppointmentDate) AS AppointmentDate,m.Diagnosis,m.TreatmentPlan ,d.Name as doctor_name  from Patients p 
                        join Appointments a on p.PatientId= a.PatientId 
                        join MedicalRecords m on p.PatientId=m.PatientId
                        join Doctors d on d.DoctorId=m.DoctorId
                        ";

            var PatientVisitHistory = con.Query(query)
                .Select(a => new
                {
                    PatientName = (string)a.patient_name,
                    AppointmentDate = (DateTime)a.AppointmentDate,
                    Diagnosis = (string)a.Diagnosis,
                    TreatmentPlan = (string)a.TreatmentPlan,
                    DoctorName = (string)a.doctor_name
                })
                .ToList();


            dgv_patients.AutoGenerateColumns = true;
            dgv_patients.DataSource = PatientVisitHistory;

        }
        //select patient to get his visit history
        private void com_patients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_load)
            {
                if (com_patients.SelectedIndex == null)
                {
                    MessageBox.Show("select patient frist ");
                    return;

                }
                int patient_id;
                if (!int.TryParse(com_patients.SelectedValue.ToString(), out patient_id))
                {
                    MessageBox.Show("Invalid patient value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    GeneratePatientVisitHistoryReport(patient_id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loding patient data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }

        //export visit history to excel
        private void btn_patient_visit_history_Click(object sender, EventArgs e)
        {
            ExportReportToExcel(dgv_patients);
        }
        #endregion









        private void btn_back_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

      

        private void btn_logout_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to Log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
        }


    

     //   }
    }
}
