--Query 3: All patients with a specific condition by doctor

DROP PROCEDURE IF EXISTS Hospital.GetPatientsWithConditionByDoctor;
GO

CREATE PROCEDURE Hospital.GetPatientsWithConditionByDoctor
        @ConditionName NVARCHAR(64)
AS
SELECT C.CommonName, CIp.FirstName AS PatientFirstName, CIp.LastName AS PatientLastName,
         PS.AdmittanceDate, PS.DischargeDate, CId.FirstName AS DoctorFirstName, CId.LastName AS DoctorLastName,
         COUNT(P.PatientID) OVER(PARTITION BY D.DoctorID) AS NumberOfPatients
FROM Hospital.Condition C
INNER JOIN Hospital.PatientStayCondtion PSC ON PSC.ConditionID = C.ConditionID
INNER JOIN Hospital.PatientStay PS ON PS.PatientStayID = PSC.PatientStayID
INNER JOIN Hospital.Patient P ON P.PatientID = PS.PatientID
INNER JOIN Hospital.ContactInfo CIp ON CIp.ContactInfoID = P.ContactInfoID
INNER JOIN Hospital.PatientStayDoctor PSD ON PSD.PatientStayID = PS.PatientStayID
INNER JOIN Hospital.Doctor D ON D.DoctorID = PSD.DoctorID
INNER JOIN Hospital.ContactInfo CId ON CId.ContactInfoID = D.ContactInfoID
WHERE P.IsRemoved IS NOT NULL AND C.CommonName = @ConditionName
ORDER BY NumberOfPatients DESC;
GO

EXEC Hospital.GetPatientsWithConditionByDoctor 'Coronavirus';

--Query 4: doctors who have treated a condition 
--with most common treatment for each doctor
DROP PROCEDURE IF EXISTS Hospital.GetDoctorTreatingConditionWithComTreatment;
GO

CREATE PROCEDURE Hospital.GetDoctorTreatingConditionWithComTreatment
        @ConditionName NVARCHAR(64)
AS
WITH DoctorTreatmentCTE(DoctorID, DoctorFirstName, DoctorLastName, ConditionName, TreatmentName, NumOfTreatmentUse) 
AS
(
    SELECT D.DoctorID, CI.FirstName AS DoctorFirstName, CI.LastName AS DoctorLastName, C.CommonName AS ConditionName, T.Name AS TreatmentName,
            COUNT( T.TreatmentID) OVER(PARTITION BY D.DoctorID) AS NumOfTreatmentUse
    FROM Hospital.Doctor D
    INNER JOIN Hospital.ContactInfo CI ON CI.ContactInfoID = D.ContactInfoID
    INNER JOIN Hospital.PatientStayDoctor PSD ON PSD.DoctorID = D.DoctorID
    INNER JOIN Hospital.PatientStay PS ON PS.PatientStayID = PSD.PatientStayID
    INNER JOIN Hospital.PatientStayTreatment PST ON PST.PatientStayID = PS.PatientStayID
    INNER JOIN Hospital.Treatment T ON T.TreatmentID = PST.TreatmentID
    INNER JOIN Hospital.PatientStayCondtion PSC ON PSC.PatientStayID = PS.PatientStayID
    INNER JOIN Hospital.Condition C ON C.ConditionID = PSC.ConditionID
    WHERE D.IsRemoved IS NOT NULL AND PS.IsRemoved IS NOT NULL AND T.IsRemoved IS NOT NULL
                AND C.CommonName = @ConditionName
)
SELECT DCTE.ConditionName, DCTE.TreatmentName, DCTE.DoctorFirstName, DCTE.DoctorLastName, DCTE.NumOfTreatmentUse
FROM DoctorTreatmentCTE DCTE
ORDER BY DCTE.NumOfTreatmentUse DESC;
GO

EXEC Hospital.GetDoctorTreatingConditionWithComTreatment 'Coronavirus';

--Query 7: conditions by name
DROP PROCEDURE IF EXISTS Hospital.GetConditionByPatientName;
GO

CREATE PROCEDURE Hospital.GetConditionByPatientName
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64)
AS

SELECT C.FirstName, C.LastName, P.PatientID, Con.CommonName AS ConditionName
FROM Hospital.Patient P
INNER JOIN Hospital.ContactInfo C ON C.ContactInfoID = P.ContactInfoID
INNER JOIN Hospital.PatientStay PS ON PS.PatientID = P.PatientID
INNER JOIN Hospital.PatientStayCondtion PSC ON PSC.PatientStayID = PS.PatientStayID
INNER JOIN Hospital.Condition Con ON Con.ConditionID = PSC.ConditionID
WHERE P.IsRemoved IS NOT NULL 
        AND C.FirstName = @FirstName
        AND C.LastName = @LastName
ORDER BY Con.CommonName ASC;
GO

EXEC Hospital.GetConditionByPatientName 'Wylie', 'Ashley';

--Query 8: Treatments by name
DROP PROCEDURE IF EXISTS Hospital.GetTreatmentByPatientName;
GO

CREATE PROCEDURE Hospital.GetTreatmentByPatientName
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64)
AS

SELECT C.FirstName, C.LastName, P.PatientID, T.Name AS TreatmentName
FROM Hospital.Patient P
INNER JOIN Hospital.ContactInfo C ON C.ContactInfoID = P.ContactInfoID
INNER JOIN Hospital.PatientStay PS ON PS.PatientID = P.PatientID
INNER JOIN Hospital.PatientStayTreatment PST ON PST.PatientStayID = PS.PatientStayID
INNER JOIN Hospital.Treatment T ON T.TreatmentID = PST.TreatmentID
WHERE P.IsRemoved IS NOT NULL 
        AND C.FirstName = @FirstName
        AND C.LastName = @LastName
ORDER BY PS.AdmittanceDate;
GO

EXEC Hospital.GetTreatmentByPatientName 'Wylie', 'Ashley'

--Query 11: List of patients by doctor
DROP PROCEDURE IF EXISTS Hospital.GetPatientByDoctor;
GO

CREATE PROCEDURE Hospital.GetPatientByDoctor
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64)
AS

SELECT CI.FirstName AS DoctorFirstName, CI.LastName AS DoctorLastName, 
        CIp.FirstName AS PatientFirstName,CIp.LastName AS PatientLastName,
        PS.AdmittanceDate, PS.DischargeDate
FROM Hospital.Doctor D 
INNER JOIN Hospital.ContactInfo CI ON D.ContactInfoID = CI.ContactInfoID
INNER JOIN Hospital.PatientStayDoctor PSD ON PSD.DoctorID = D.DoctorID
INNER JOIN Hospital.PatientStay PS ON PS.PatientStayID = PSD.PatientStayID
INNER JOIN Hospital.Patient P ON P.PatientID = PS.PatientID
INNER JOIN Hospital.ContactInfo CIp ON CIp.ContactInfoID = P.ContactInfoID
WHERE P.IsRemoved IS NOT NULL
        AND CI.FirstName = @FirstName
        AND CI.LastName = @LastName
ORDER BY PS.AdmittanceDate ASC;
GO

EXEC Hospital.GetPatientByDoctor 'Rowan', 'Wood';

--Query 12: List of doctors by patient
DROP PROCEDURE IF EXISTS Hospital.GetDoctorByPatient;
GO

CREATE PROCEDURE Hospital.GetDoctorByPatient
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64)
AS

SELECT CIp.FirstName AS PatientFirstName,CIp.LastName AS PatientLastName,
        CI.FirstName AS DoctorFirstName, CI.LastName AS DoctorLastName        
FROM Hospital.Patient P 
INNER JOIN Hospital.ContactInfo CIp ON CIp.ContactInfoID = P.ContactInfoID
INNER JOIN Hospital.PatientStay PS ON PS.PatientID = P.PatientID
INNER JOIN Hospital.PatientStayDoctor PSD ON PSD.PatientStayID = PS.PatientStayID
INNER JOIN Hospital.Doctor D ON D.DoctorID = PSD.DoctorID
INNER JOIN Hospital.ContactInfo CI ON D.ContactInfoID = CI.ContactInfoID
WHERE P.IsRemoved IS NOT NULL
        AND CIp.FirstName = @FirstName
        AND CIp.LastName = @LastName
ORDER BY CI.FirstName ASC, CI.LastName ASC;
GO

EXEC Hospital.GetDoctorByPatient 'Wylie', 'Ashley'