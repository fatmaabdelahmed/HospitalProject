SELECT * 
FROM sys.foreign_keys 
WHERE name = 'FK_Billings_Appointments_AppointmentId';

ALTER TABLE Billings DROP CONSTRAINT FK_Billings_Appointments_AppointmentId;
SELECT * FROM sys.foreign_keys WHERE name = 'FK_Billings_Appointments_AppointmentId';
ALTER TABLE Billings DROP CONSTRAINT FK_Billings_Appointments_AppointmentId;
DELETE FROM __EFMigrationsHistory WHERE MigrationId = '20250305214845_FixBillingDeleteFinal';
