/* (Table)_Data_FULL tables were created using the SQL Server Import Extension.
A .csv file was created by generatedata.com that was imported into our database
via the Import Flat File Wizard. We then used these tables to populate our own. */

DROP TABLE IF EXISTS Hospital.PatientStayTreatement_Data_FULL;
DROP TABLE IF EXISTS Hospital.PatientStayCondition_Data_FULL;
DROP TABLE IF EXISTS Hospital.PatientStayDoctor_Data_FULL;
DROP TABLE IF EXISTS Hospital.PatientStay_Data_FULL;
DROP TABLE IF EXISTS Hospital.Treatment_Data_FULL;
DROP TABLE IF EXISTS Hospital.Condition_Data_FULL;
DROP TABLE IF EXISTS Hospital.Doctor_Data_Full;
DROP TABLE IF EXISTS Hospital.Patients_Data_FULL;
DROP TABLE IF EXISTS Hospital.Contacts_Data_Full;
GO

INSERT Hospital.ContactInfo(FirstName, LastName, PhoneNumber, Email, AddressLine, City, [State], ZipCode, Country, IsRemoved)
SELECT S.FirstName, S.LastName, S.PhoneNumber, S.Email, S.AddressLine1, S.City, S.[State], S.ZipCode, S.Country, 0
FROM Hospital.Contacts_Data_FULL S;

INSERT Hospital.Patient(ContactInfoID, EmergencyContactInfoID, BirthDate, Sex, IsRemoved)
SELECT S.ContactInfoID, S.EmergencyContactID, S.BirthDate, S.Sex, 0
FROM Hospital.Patients_Data_FULL S;

INSERT Hospital.Doctor(ContactInfoID, PracticeStartDate, Degree, Unit, IsRemoved)
SELECT S.ContactID, S.PracticeStartDate, S.Degree, S.Unit, 0
FROM Hospital.Doctor_Data_FULL S
WHERE S.ContactID IS NOT NULL AND S.PracticeStartDate IS NOT NULL
    AND S.Degree IS NOT NULL AND S.Unit IS NOT NULL;

INSERT Hospital.Condition(CommonName, TechnicalName, IsRemoved)
SELECT S.CommonName, S.TechnicalName, 0
FROM Hospital.Condition_Data_FULL S;

INSERT Hospital.Treatment([Name], ApplicationFrequency, ApplicationType, IsRemoved)
SELECT S.[Name], S.ApplicationFrequency, S.ApplicationType, 0
FROM Hospital.Treatment_Data_FULL S;

INSERT Hospital.PatientStay(PatientID, AdmittanceDate, DischargeDate, Unit, RoomNumber, IsRemoved)
SELECT S.PatientID, S.AdmittanceDate, S.DischargeDate, S.Unit, S.RoomNumber, 0
FROM Hospital.PatientStay_Data_FULL S;

INSERT Hospital.PatientStayDoctor(PatientStayID, DoctorID, IsRemoved)
SELECT S.PatientStayID, S.DoctorID, 0
FROM Hospital.PatientStayDoctor_Data_FULL S
WHERE S.PatientStayID IS NOT NULL AND S.DoctorID IS NOT NULL;

INSERT Hospital.PatientStayCondtion(PatientStayID, ConditionID, IsRemoved)
SELECT S.PatientStayID, S.ConditionID, 0
FROM Hospital.PatientStayCondition_Data_FULL S
WHERE S.PatientStayID IS NOT NULL AND S.ConditionID IS NOT NULL;

INSERT Hospital.PatientStayTreatment(PatientStayID, TreatmentID, IsRemoved)
SELECT S.PatientStayID, S.TreatmentID, 0
FROM Hospital.PatientStayTreatement_Data_FULL S
WHERE S.PatientStayID IS NOT NULL AND S.TreatmentID IS NOT NULL;
GO