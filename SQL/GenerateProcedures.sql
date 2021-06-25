-- Question Queries

-- 1) Get patient info for a patient based on patient name and birthdate
CREATE OR ALTER PROCEDURE Hospital.GetPatientInfo
   @FirstName NVARCHAR(64),
   @LastName NVARCHAR(64),
   @BirthDate DATETIME
AS

SELECT CI.PhoneNumber, CI.Email, CI.AddressLine, P.Sex
FROM Hospital.ContactInfo CI
    INNER JOIN Hospital.Patient P ON P.ContactInfoID = CI.ContactInfoID
WHERE CI.FirstName = @FirstName AND CI.LastName = @LastName AND CONVERT(VARCHAR, P.BirthDate, 101) = CONVERT(VARCHAR, @BirthDate, 101)
    AND CI.IsRemoved = 0 AND P.IsRemoved = 0;
GO


-- 2) Get doctor info for a doctor based on doctor name and unit
CREATE OR ALTER PROCEDURE Hospital.GetDoctorInfo
   @FirstName NVARCHAR(64),
   @LastName NVARCHAR(64),
   @Unit NVARCHAR(64)
AS

SELECT CI.PhoneNumber, CI.Email, CI.AddressLine, D.PracticeStartDate, D.Degree
FROM Hospital.ContactInfo CI
    INNER JOIN Hospital.Doctor D ON D.ContactInfoID = CI.ContactInfoID
WHERE CI.FirstName = @FirstName AND CI.LastName = @LastName AND D.Unit = @Unit
    AND CI.IsRemoved = 0 AND D.IsRemoved = 0;
GO


-- 3) Get emergency contact info for a patient based on patient name and birthdate
CREATE OR ALTER PROCEDURE Hospital.GetPatientEmergencyContactInfo
   @FirstName NVARCHAR(64),
   @LastName NVARCHAR(64),
   @BirthDate DATETIME
AS

SELECT ECI.FirstName, ECI.LastName, ECI.PhoneNumber, ECI.Email, ECI.AddressLine
FROM Hospital.ContactInfo CI
    INNER JOIN Hospital.Patient P ON P.ContactInfoID = CI.ContactInfoID
    INNER JOIN Hospital.ContactInfo ECI ON ECI.ContactInfoID = P.EmergencyContactInfoID
WHERE CI.FirstName = @FirstName AND CI.LastName = @LastName AND CONVERT(VARCHAR, P.BirthDate, 101) = CONVERT(VARCHAR, @BirthDate, 101)
    AND CI.IsRemoved = 0 AND P.IsRemoved = 0 AND ECI.IsRemoved = 0;
GO


-- 4) Get a list of stays for a patient based on patient name and birthdate
CREATE OR ALTER PROCEDURE Hospital.GetPatientStays
   @FirstName NVARCHAR(64),
   @LastName NVARCHAR(64),
   @BirthDate DATETIME
AS

SELECT PS.AdmittanceDate, PS.DischargeDate, PS.Unit, PS.RoomNumber
FROM Hospital.ContactInfo CI
    INNER JOIN Hospital.Patient P ON P.ContactInfoID = CI.ContactInfoID
    INNER JOIN Hospital.PatientStay PS ON PS.PatientID = P.PatientID
WHERE CI.FirstName = @FirstName AND CI.LastName = @LastName AND CONVERT(VARCHAR, P.BirthDate, 101) = CONVERT(VARCHAR, @BirthDate, 101)
    AND CI.IsRemoved = 0 AND P.IsRemoved = 0 AND PS.IsRemoved = 0
ORDER BY PS.AdmittanceDate DESC;
GO


-- 5) Get a list of conditions for a patient based on patient name and birthdate
CREATE OR ALTER PROCEDURE Hospital.GetConditionByPatientName
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @BirthDate DATETIME
AS

SELECT Con.CommonName, Con.TechnicalName
FROM Hospital.Patient P
INNER JOIN Hospital.ContactInfo C ON C.ContactInfoID = P.ContactInfoID
INNER JOIN Hospital.PatientStay PS ON PS.PatientID = P.PatientID
INNER JOIN Hospital.PatientStayCondtion PSC ON PSC.PatientStayID = PS.PatientStayID
INNER JOIN Hospital.Condition Con ON Con.ConditionID = PSC.ConditionID
WHERE P.IsRemoved IS NOT NULL 
        AND C.FirstName = @FirstName
        AND C.LastName = @LastName
        AND CONVERT(VARCHAR, P.BirthDate, 101) = CONVERT(VARCHAR, @BirthDate, 101)
ORDER BY Con.CommonName ASC;
GO


-- 6) Get a list of treatments for a patient based on patient name and birthdate
CREATE OR ALTER PROCEDURE Hospital.GetTreatmentByPatientName
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @BirthDate DATETIME
AS

SELECT T.Name, T.ApplicationType, T.ApplicationFrequency
FROM Hospital.Patient P
INNER JOIN Hospital.ContactInfo C ON C.ContactInfoID = P.ContactInfoID
INNER JOIN Hospital.PatientStay PS ON PS.PatientID = P.PatientID
INNER JOIN Hospital.PatientStayTreatment PST ON PST.PatientStayID = PS.PatientStayID
INNER JOIN Hospital.Treatment T ON T.TreatmentID = PST.TreatmentID
WHERE P.IsRemoved IS NOT NULL 
        AND C.FirstName = @FirstName
        AND C.LastName = @LastName
        AND CONVERT(VARCHAR, P.BirthDate, 101) = CONVERT(VARCHAR, @BirthDate, 101)
ORDER BY T.Name;
GO


-- 7) Get a list of patients for a doctor based on doctor name and unit
CREATE OR ALTER PROCEDURE Hospital.GetPatientByDoctor
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @Unit NVARCHAR(64)
AS

SELECT CIp.FirstName, CIp.LastName
FROM Hospital.Doctor D 
INNER JOIN Hospital.ContactInfo CI ON D.ContactInfoID = CI.ContactInfoID
INNER JOIN Hospital.PatientStayDoctor PSD ON PSD.DoctorID = D.DoctorID
INNER JOIN Hospital.PatientStay PS ON PS.PatientStayID = PSD.PatientStayID
INNER JOIN Hospital.Patient P ON P.PatientID = PS.PatientID
INNER JOIN Hospital.ContactInfo CIp ON CIp.ContactInfoID = P.ContactInfoID
WHERE P.IsRemoved IS NOT NULL
        AND CI.FirstName = @FirstName
        AND CI.LastName = @LastName
        AND D.Unit = @Unit
ORDER BY CIp.LastName ASC;
GO


-- 8) Get a list of doctors for a patient based on patient name and birthdate
CREATE OR ALTER PROCEDURE Hospital.GetDoctorByPatient
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @BirthDate DATETIME
AS

SELECT CI.FirstName, CI.LastName       
FROM Hospital.Patient P 
INNER JOIN Hospital.ContactInfo CIp ON CIp.ContactInfoID = P.ContactInfoID
INNER JOIN Hospital.PatientStay PS ON PS.PatientID = P.PatientID
INNER JOIN Hospital.PatientStayDoctor PSD ON PSD.PatientStayID = PS.PatientStayID
INNER JOIN Hospital.Doctor D ON D.DoctorID = PSD.DoctorID
INNER JOIN Hospital.ContactInfo CI ON D.ContactInfoID = CI.ContactInfoID
WHERE P.IsRemoved IS NOT NULL
        AND CIp.FirstName = @FirstName
        AND CIp.LastName = @LastName
        AND CONVERT(VARCHAR, P.BirthDate, 101) = CONVERT(VARCHAR, @BirthDate, 101)
ORDER BY CI.LastName ASC;
GO



-- Report Queries

-- 1) Get hospital condition history based on condition name
CREATE OR ALTER PROCEDURE Hospital.GetHospitalConditionHistory
   @ConditionName NVARCHAR(64)
AS

WITH Doctors(DoctorID, FirstName, LastName, Degree) AS
(
    SELECT D.DoctorID, CI.FirstName, CI.LastName, D.Degree
    FROM Hospital.ContactInfo CI
        INNER JOIN Hospital.Doctor D ON D.ContactInfoID = CI.ContactInfoID
    WHERE CI.IsRemoved = 0 AND D.IsRemoved = 0
)
SELECT PS.AdmittanceDate, PS.DischargeDate, PS.PatientID, D.FirstName AS DoctorFirstName, D.LastName AS DoctorLastName, D.Degree AS DoctorDegree,
    COUNT(PS.PatientStayID) OVER(
        PARTITION BY YEAR(PS.AdmittanceDate)
        ORDER BY PS.AdmittanceDate DESC
        ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) AS YtdCases
FROM Hospital.Condition C
    INNER JOIN Hospital.PatientStayCondtion PSC ON PSC.ConditionID = C.ConditionID
    INNER JOIN Hospital.PatientStay PS ON PS.PatientStayID = PSC.PatientStayID
    INNER JOIN Hospital.PatientStayDoctor PSD ON PSD.PatientStayID = PS.PatientStayID
    INNER JOIN Doctors D ON D.DoctorID = PSD.DoctorID
WHERE C.CommonName = @ConditionName AND C.IsRemoved = 0 AND PSC.IsRemoved = 0 AND PS.IsRemoved = 0 AND PSD.IsRemoved = 0
GROUP BY PS.PatientStayID, PS.AdmittanceDate, PS.DischargeDate, PS.PatientID, D.FirstName, D.LastName, D.Degree
ORDER BY PS.AdmittanceDate DESC;
GO


-- 2) Get doctor condition history based on doctor name and unit
CREATE OR ALTER PROCEDURE Hospital.GetDoctorConditionHistory
   @FirstName NVARCHAR(64),
   @LastName NVARCHAR(64),
   @Unit NVARCHAR(64)
AS

WITH DoctorPatientStays(PatientStayID) AS
(
    SELECT PSD.PatientStayID
    FROM Hospital.ContactInfo CI
        INNER JOIN Hospital.Doctor D ON D.ContactInfoID = CI.ContactInfoID
        INNER JOIN Hospital.PatientStayDoctor PSD ON PSD.DoctorID = D.DoctorID
    WHERE CI.FirstName = @FirstName AND CI.LastName = @LastName AND D.Unit = @Unit
        AND CI.IsRemoved = 0 AND D.IsRemoved = 0 AND PSD.IsRemoved = 0
)
SELECT C.CommonName AS ConditionName, T.Name AS TreatmentName, DATEDIFF(day, PS.DischargeDate, PS.AdmittanceDate) AS LengthOfStay
FROM DoctorPatientStays DPS
    INNER JOIN Hospital.PatientStay PS ON PS.PatientStayID = DPS.PatientStayID
    INNER JOIN Hospital.PatientStayCondtion PSC ON PSC.PatientStayID = PS.PatientStayID
    INNER JOIN Hospital.Condition C ON C.ConditionID = PSC.ConditionID
    INNER JOIN Hospital.PatientStayTreatment PST ON PST.PatientStayID = PS.PatientStayID
    INNER JOIN Hospital.Treatment T ON T.TreatmentID = PST.TreatmentID
WHERE PS.IsRemoved = 0 AND PSC.IsRemoved = 0 AND C.IsRemoved = 0 AND PST.IsRemoved = 0 AND T.IsRemoved = 0
GROUP BY PS.PatientStayID, C.CommonName, T.Name, PS.DischargeDate, PS.AdmittanceDate
ORDER BY C.CommonName, T.Name;
GO


-- 3) Get patients by doctor based on condition name
CREATE OR ALTER PROCEDURE Hospital.GetPatientsWithConditionByDoctor
        @ConditionName NVARCHAR(64)
AS

SELECT CIp.FirstName AS PatientFirstName, CIp.LastName AS PatientLastName,
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


-- 4) Get doctors that have treated a condition with their treatment based on condition name
CREATE OR ALTER PROCEDURE Hospital.GetDoctorTreatingConditionWithComTreatment
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



-- MERGE Statements

-- Add/Update Patient
CREATE OR ALTER PROCEDURE Hospital.AddPatient
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @PhoneNumber NVARCHAR(64),
        @Email NVARCHAR(64),
        @AddressLine NVARCHAR(64),
        @City NVARCHAR(64),
        @State NVARCHAR(64),
        @ZipCode NVARCHAR(64),
        @Country NVARCHAR(64),

        @EmergencyContactInfoID INT,
        @BirthDate DATETIME,
        @Sex INT
AS

WITH GetContactDataCTE(FirstName, LastName, Phone, Email, [Address],
                City, [State], ZipCode, Country)
AS
(
SELECT @FirstName, @LastName, @PhoneNumber, @Email, @AddressLine,
        @City, @State, @ZipCode, @Country
)

MERGE Hospital.ContactInfo T
USING GetContactDataCTE S ON S.Phone = T.PhoneNumber
                      AND S.Email = T.Email
WHEN MATCHED THEN
UPDATE
SET FirstName = S.FirstName,
    LastName = S.LastName,
    AddressLine = S.Address, 
    City = S.City,
    ZipCode = S.ZipCode,
    Country = S.Country,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT (FirstName, LastName, PhoneNumber, Email, AddressLine, City, [State], ZipCode, Country, IsRemoved)
VALUES(S.FirstName, S.LastName, S.Phone, S.Email, S.Address, S.City, S.State, S.ZipCode, S.Country, 0);

WITH GetPatientDataCTE(FirstName, LastName, Email, ContactInfoID, EmergencyContactInfoID, BirthDate, Sex)
AS
(
SELECT @FirstName, @LastName, @Email, C.ContactInfoID, @EmergencyContactInfoID, @BirthDate, @Sex
FROM Hospital.ContactInfo C
WHERE C.FirstName = @FirstName AND C.LastName = @LastName AND C.Email = @Email
)

MERGE Hospital.Patient T
USING GetPatientDataCTE S ON S.ContactInfoID = T.ContactInfoID
WHEN MATCHED THEN
UPDATE
SET EmergencyContactInfoID = S.EmergencyContactInfoID,
    BirthDate = S.BirthDate,
    Sex = S.Sex,
    IsRemoved = 0,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT (ContactInfoID, EmergencyContactInfoID, BirthDate, Sex, IsRemoved)
VALUES(S.ContactInfoID, S.EmergencyContactInfoID, S.BirthDate, S.Sex, 0);
GO


-- Add/Update Doctor
CREATE OR ALTER PROCEDURE Hospital.AddDoctor
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @PhoneNumber NVARCHAR(64),
        @Email NVARCHAR(64),
        @AddressLine NVARCHAR(64),
        @City NVARCHAR(64),
        @State NVARCHAR(64),
        @ZipCode NVARCHAR(64),
        @Country NVARCHAR(64),

        @PracticeStartDate DATETIME,
        @Degree NVARCHAR(64),
        @Unit NVARCHAR(64)
AS

WITH GetContactDataCTE(FirstName, LastName, Phone, Email, [Address],
                City, [State], ZipCode, Country)
AS
(
SELECT @FirstName, @LastName, @PhoneNumber, @Email, @AddressLine,
        @City, @State, @ZipCode, @Country
)

MERGE Hospital.ContactInfo T
USING GetContactDataCTE S ON S.Phone = T.PhoneNumber
                      AND S.Email = T.Email
WHEN MATCHED THEN
UPDATE
SET FirstName = S.FirstName,
    LastName = S.LastName,
    AddressLine = S.Address, 
    City = S.City,
    ZipCode = S.ZipCode,
    Country = S.Country,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT (FirstName, LastName, PhoneNumber, Email, AddressLine, City, [State], ZipCode, Country, IsRemoved)
VALUES(S.FirstName, S.LastName, S.Phone, S.Email, S.Address, S.City, S.State, S.ZipCode, S.Country, 0);

WITH GetDoctorDataCTE(FirstName, LastName, Email, ContactInfoID, PracticeStartDate, Degree, Unit)
AS
(
SELECT @FirstName, @LastName, @Email, C.ContactInfoID, @PracticeStartDate, @Degree, @Unit
FROM Hospital.ContactInfo C
WHERE C.FirstName = @FirstName AND C.LastName = @LastName AND C.Email = @Email
)

MERGE Hospital.Doctor T
USING GetDoctorDataCTE S ON S.ContactInfoID = T.ContactInfoID
WHEN MATCHED THEN
UPDATE
SET PracticeStartDate = @PracticeStartDate,
    Degree = @Degree,
    Unit = @Unit,
    IsRemoved = 0,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT (ContactInfoID, PracticeStartDate, Degree, Unit, IsRemoved)
VALUES(S.ContactInfoID, S.PracticeStartDate, S.Degree, S.Unit, 0);
GO


-- Add/Update Contact
CREATE OR ALTER PROCEDURE Hospital.AddContact
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @PhoneNumber NVARCHAR(64),
        @Email NVARCHAR(64),
        @AddressLine NVARCHAR(64),
        @City NVARCHAR(64),
        @State NVARCHAR(64),
        @ZipCode NVARCHAR(64),
        @Country NVARCHAR(64)
AS

WITH GetContactDataCTE(FirstName, LastName, Phone, Email, [Address],
                City, [State], ZipCode, Country)
AS
(
SELECT @FirstName, @LastName, @PhoneNumber, @Email, @AddressLine,
        @City, @State, @ZipCode, @Country
)

MERGE Hospital.ContactInfo T
USING GetContactDataCTE S ON S.Phone = T.PhoneNumber
                      AND S.Email = T.Email
WHEN MATCHED THEN
UPDATE
SET FirstName = S.FirstName,
    LastName = S.LastName,
    AddressLine = S.Address, 
    City = S.City,
    ZipCode = S.ZipCode,
    Country = S.Country,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT (FirstName, LastName, PhoneNumber, Email, AddressLine, City, [State], ZipCode, Country, IsRemoved)
VALUES(S.FirstName, S.LastName, S.Phone, S.Email, S.Address, S.City, S.State, S.ZipCode, S.Country, 0);
GO


-- Add/Update Condition
CREATE OR ALTER PROCEDURE Hospital.AddCondition
        @CommonName NVARCHAR(64),
        @TechnicalName NVARCHAR(64)
AS

WITH ConditionDataCTE(CommonName, TechnicalName)
AS
(
    SELECT @CommonName, @TechnicalName
)
MERGE Hospital.Condition T
USING ConditionDataCTE S ON S.TechnicalName = T.TechnicalName
WHEN MATCHED THEN
UPDATE 
SET CommonName = S.CommonName,
    IsRemoved = 0,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT(CommonName, TechnicalName, IsRemoved)
VALUES(S.CommonName, S.TechnicalName, 0);
GO


-- Add/Update Treatment
CREATE OR ALTER PROCEDURE Hospital.AddTreatment
        @Name NVARCHAR(64),
        @ApplicationFrequency NVARCHAR(64),
        @ApplicationType NVARCHAR(64)
AS

WITH TreatmentDataCTE([Name], ApplicationFrequency, ApplicationType)
AS
(
    SELECT @Name, @ApplicationFrequency, @ApplicationType
)
MERGE Hospital.Treatment T
USING TreatmentDataCTE S ON S.Name = T.Name AND S.ApplicationFrequency = T.ApplicationFrequency
                            AND S.ApplicationType = T.ApplicationType
WHEN MATCHED THEN
UPDATE 
SET IsRemoved = 0,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT([Name], ApplicationFrequency, ApplicationType, IsRemoved)
VALUES(S.Name, S.ApplicationFrequency,S.ApplicationType, 0);
GO


-- Add/Update PatientStayDoctor
CREATE OR ALTER PROCEDURE Hospital.AddPatientStayDoctor
    @PatientID INT,
    @DoctorID INT,
    @AdmittanceDate DATETIME,
    @DischargeDate DATETIME
AS
WITH GetPatientStayIdCTE(PatientStayID, DoctorID)
AS
(
    SELECT PS.PatientStayID, @DoctorID
    FROM Hospital.PatientStay PS 
    WHERE PS.PatientID = @PatientID
        AND PS.AdmittanceDate = @AdmittanceDate
        AND PS.DischargeDate = @DischargeDate
)

MERGE Hospital.PatientStayDoctor T 
USING GetPatientStayIdCTE S ON S.PatientStayID = T.PatientStayID
                            AND S.DoctorID = T.DoctorID
WHEN MATCHED THEN
UPDATE 
SET IsRemoved = 0,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT(PatientStayID, DoctorID, IsRemoved)
VALUES(S.PatientStayID, S.DoctorID, 0);
GO


-- Add/Update PatientStayTreatment
CREATE OR ALTER PROCEDURE Hospital.AddPatientStayTreatment
    @PatientID INT,
    @TreatmentID INT,
    @AdmittanceDate DATETIME,
    @DischargeDate DATETIME
AS
WITH GetPatientStayIdCTE(PatientStayID, TreatmentID)
AS
(
    SELECT PS.PatientStayID, @TreatmentID
    FROM Hospital.PatientStay PS 
    WHERE PS.PatientID = @PatientID
        AND PS.AdmittanceDate = @AdmittanceDate
        AND PS.DischargeDate = @DischargeDate
)

MERGE Hospital.PatientStayTreatment T 
USING GetPatientStayIdCTE S ON S.PatientStayID = T.PatientStayID
                            AND S.TreatmentID = T.TreatmentID
WHEN MATCHED THEN
UPDATE 
SET IsRemoved = 0,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT(PatientStayID, TreatmentID, IsRemoved)
VALUES(S.PatientStayID, S.TreatmentID, 0);
GO


-- Add/Update PatientStayCondition
CREATE OR ALTER PROCEDURE Hospital.AddPatientStayCondition
    @PatientID INT,
    @ConditionID INT,
    @AdmittanceDate DATETIME,
    @DischargeDate DATETIME
AS
WITH GetPatientStayIdCTE(PatientStayID, ConditionID)
AS
(
    SELECT PS.PatientStayID, @ConditionID
    FROM Hospital.PatientStay PS 
    WHERE PS.PatientID = @PatientID
        AND PS.AdmittanceDate = @AdmittanceDate
        AND PS.DischargeDate = @DischargeDate
)

MERGE Hospital.PatientStayCondtion T 
USING GetPatientStayIdCTE S ON S.PatientStayID = T.PatientStayID
                            AND S.ConditionID = T.ConditionID
WHEN MATCHED THEN
UPDATE 
SET IsRemoved = 0,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT(PatientStayID, ConditionID, IsRemoved)
VALUES(S.PatientStayID, S.ConditionID, 0);
GO


-- Add/Update PatientStay
CREATE OR ALTER PROCEDURE Hospital.AddPatientStay
        @PatientID INT,
        @AdmittanceDate DATETIME,
        @DischargeDate DATETIME,
        @Unit NVARCHAR(64),
        @RoomNumber INT,

        @ConditionID INT,

        @DoctorID INT,

        @TreatmentID INT
AS

WITH PatientStayDataCTE (PatientID, AdmittanceDate, DischargeDate, Unit, RoomNumber, 
                        DoctorID, TreatentID)
AS
(
    SELECT @PatientID, @AdmittanceDate, @DischargeDate, @Unit, @RoomNumber, @DoctorID, @TreatmentID
)

MERGE Hospital.PatientStay T
USING PatientStayDataCTE S ON S.PatientID = T.PatientID 
                            AND S.AdmittanceDate = T.AdmittanceDate
                            AND S.DischargeDate = T.DischargeDate
                            AND S.Unit = T.Unit 
                            AND S.RoomNumber = T.RoomNumber
WHEN MATCHED THEN
UPDATE 
SET IsRemoved = 0,
    UpdatedOn = SYSDATETIME()
WHEN NOT MATCHED THEN
INSERT (PatientID, AdmittanceDate, DischargeDate, Unit, RoomNumber, IsRemoved)
VALUES(S.PatientID, S.AdmittanceDate, S.DischargeDate, S.Unit, S.RoomNumber, 0);

EXEC Hospital.AddPatientStayDoctor @PatientID, @DoctorID, @AdmittanceDate, @DischargeDate;
EXEC Hospital.AddPatientStayTreatment @PatientID, @TreatmentID, @AdmittanceDate, @DischargeDate;
EXEC Hospital.AddPatientStayCondition @PatientID, @ConditionID, @AdmittanceDate, @DischargeDate;
GO