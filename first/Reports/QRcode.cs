using System;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
 
using Dapper;
using Microsoft.EntityFrameworkCore;
using first.models;
using Microsoft.Data.SqlClient;
 
using QRCoder;

namespace first.Reports
{
    public partial class QRcode : Form
    {
        private readonly DbConnection con;

        private int PatientID;
        public QRcode(int id)

        {
            InitializeComponent();
            HOSPITALDbContext db = new HOSPITALDbContext();
            con = db.Database.GetDbConnection();
            PatientID = id;
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            int patientID = PatientID;

            var patientData = GetPatientData(patientID);
            if (patientData != null)
            {
                GenerateQRCode(patientData);
            }
            else
            {
                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private string GetPatientData(int patientID)
        {

            {

                var query = "SELECT * FROM  Patients p    WHERE p.PatientId = @PatientID";
                var patient = con.QueryFirstOrDefault<Patient>(query, new { PatientID = patientID });

                if (patient != null)
                {

                    return $"ID: {patient.PatientId}," + " \n" +
                        $" Name: {patient.Name},  " + " \n" +
                        $"DOB: {patient.DateOfBirth.ToString("dd-MM-yyyy")}" + " \n" +
                        $" medical record : {patient.MedicalHistory}, " + " \n" +
                        $" contact info: {patient.ContactInfo}";
                }
            }
            return null;
        }


        //private void GenerateQRCode(string data)
        //{
        //    using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        //    {
        //        // Generate QR code data
        //        QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
        //        using (QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData))
        //        {
        //            // Create a QR code image with a fixed size of 70x70 pixels
        //            int fixedSize = 700; // Desired size in pixels
        //            Bitmap qrCodeImage = qrCode.GetGraphic(5); // Adjust pixelsPerModule to control the size

        //            // Resize the QR code to 70x70 pixels
        //            Bitmap resizedQrCode = new Bitmap(qrCodeImage, new Size(fixedSize, fixedSize));

        //            // Display the resized QR code in the PictureBox
        //            pictureBoxQRCode.Image = resizedQrCode;
        //        }
        //    }
        //}


        private void GenerateQRCode(string data)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                // Generate QR code data
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                using (QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData))
                {
                    // Generate QR code with proper scaling to 70x70 pixels
                    Bitmap qrCodeImage = qrCode.GetGraphic(10, Color.Black, Color.White, true);

                    // Resize to ensure it is exactly 70x70  pixels
                    Bitmap resizedQrCode = new Bitmap(qrCodeImage, new Size(322, 368));

                    // Display the resized QR code in the PictureBox
                    pictureBoxQRCode.Image = resizedQrCode;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}