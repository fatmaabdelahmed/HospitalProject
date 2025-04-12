# Hospital Patient Management System  

## About the System  
The **Hospital Patient Management System** is a **C# .NET WinForms** desktop application that streamlines hospital operations by managing **patients, doctors, appointments, medical records, and billing** efficiently.  

## Key Features  
- **Doctor Management** – Manage doctor records, schedules, and specialization.  
- **Appointment Scheduling** – Book, update, and cancel patient appointments, and Send Reminder(Email).  
- **Medical Records** – Store patient diagnoses, treatments, and prescriptions.  
- **Billing System** – Generate invoices and process payments.  
- **Role-Based Access** – Admin, Doctor, Receptionist, Patient, and Billing Staff.  
- **Reports & Analytics** – Export reports on appointments, medical history, and financials.  
- **Secure Login & Authentication** – Role-based authentication for system access.  
- **QR Code Integration** – Generate QR codes for patient details.  

## Technologies Used  
- **C# (WinForms .NET Framework)** – User Interface development  
- **SQL Server** – Database storage  
- **Entity Framework Core & Dapper** – ORM & direct queries  
- **QR Code Generator** – For patient records  
- **Code-First Approach with Migrations**  

## System Roles & Actors  
| Role           | Responsibilities |
|---------------|----------------|
| **Admin**       | Manage users, doctors, and reports. |
| **Doctor**      | View & update patient medical records and appointments. |
| **Receptionist** | Register patients, schedule appointments. |
| **Billing Staff** | Handle invoices, billing, and payments. |

## Installation & Setup  
### **Prerequisites**  
- Install **.NET Framework (Latest Version)**  
- Install **SQL Server & SQL Server Management Studio (SSMS)**  
- Install **Visual Studio with .NET Desktop Development**  
- Clone the repository:  
  ```sh
  git clone https://github.com/fatmaabdelahmed/HospitalProject.git
