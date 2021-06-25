--Drop all procedures
DROP PROCEDURE IF EXISTS Hospital.AddPatient;
DROP PROCEDURE IF EXISTS Hospital.AddDoctor;
DROP PROCEDURE IF EXISTS Hospital.AddContact;
DROP PROCEDURE IF EXISTS Hospital.AddCondition;
DROP PROCEDURE IF EXISTS Hospital.AddTreatment;
DROP PROCEDURE IF EXISTS Hospital.AddPatientStay;
DROP PROCEDURE IF EXISTS Hospital.AddPatientStayDoctor;
DROP PROCEDURE IF EXISTS Hospital.AddPatientStayCondition;
DROP PROCEDURE IF EXISTS Hospital.AddPatientStayTreatment;
GO

--ADD PATIENT PROCEDURE
CREATE PROCEDURE Hospital.AddPatient
        --params for contact
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @PhoneNumber NVARCHAR(64),
        @Email NVARCHAR(64),
        @AddressLine NVARCHAR(64),
        @City NVARCHAR(64),
        @State NVARCHAR(64),
        @ZipCode NVARCHAR(64),
        @Country NVARCHAR(64),
        --params for patient
        @EmergencyContactInfoID INT,
        @BirthDate DATETIME,
        @Sex INT
AS
--put data into a CTE
WITH GetContactDataCTE(FirstName, LastName, Phone, Email, [Address],
                City, [State], ZipCode, Country)
AS
(
SELECT @FirstName, @LastName, @PhoneNumber, @Email, @AddressLine,
        @City, @State, @ZipCode, @Country
)
--add the contact info first
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

--then add patient data
--put data into a CTE
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


--ADD DOCTOR PROCEDURE

CREATE PROCEDURE Hospital.AddDoctor
        --params for contact
        @FirstName NVARCHAR(64),
        @LastName NVARCHAR(64),
        @PhoneNumber NVARCHAR(64),
        @Email NVARCHAR(64),
        @AddressLine NVARCHAR(64),
        @City NVARCHAR(64),
        @State NVARCHAR(64),
        @ZipCode NVARCHAR(64),
        @Country NVARCHAR(64),
        --params for patient
        @PracticeStartDate DATETIME,
        @Degree NVARCHAR(64),
        @Unit NVARCHAR(64)
AS
--put data into a CTE
WITH GetContactDataCTE(FirstName, LastName, Phone, Email, [Address],
                City, [State], ZipCode, Country)
AS
(
SELECT @FirstName, @LastName, @PhoneNumber, @Email, @AddressLine,
        @City, @State, @ZipCode, @Country
)
--add the contact info first
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

--Now insert into doctor
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


--ADD CONTACT PROCEDURE

CREATE PROCEDURE Hospital.AddContact
        --params for contact
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
--put data into a CTE
WITH GetContactDataCTE(FirstName, LastName, Phone, Email, [Address],
                City, [State], ZipCode, Country)
AS
(
SELECT @FirstName, @LastName, @PhoneNumber, @Email, @AddressLine,
        @City, @State, @ZipCode, @Country
)
--add the contact info
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



--ADD CONDITION PROCEDURE


CREATE PROCEDURE Hospital.AddCondition
        --params for condition
        @CommonName NVARCHAR(64),
        @TechnicalName NVARCHAR(64)
AS
--store data in CTE for merge
WITH ConditionDataCTE(CommonName, TechnicalName)
AS
(
    SELECT @CommonName, @TechnicalName
)--end CTE
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

--ADD TREATMENT PROCEDURE

CREATE PROCEDURE Hospital.AddTreatment
        --params for condition
        @Name NVARCHAR(64),
        @ApplicationFrequency NVARCHAR(64),
        @ApplicationType NVARCHAR(64)
AS
--store data in CTE for merge
WITH TreatmentDataCTE([Name], ApplicationFrequency, ApplicationType)
AS
(
    SELECT @Name, @ApplicationFrequency, @ApplicationType
)--end CTE
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

--ADD PATIENT STAY DOCTOR PROCEDURE
CREATE PROCEDURE Hospital.AddPatientStayDoctor
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
--now update patient stay doctor
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


--ADD PATIENT STAY TREATMENT PROCEDURE
CREATE PROCEDURE Hospital.AddPatientStayTreatment
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

--now update patient stay treatment
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


--ADD PATIENT STAY CONDITION PROCEDURE
CREATE PROCEDURE Hospital.AddPatientStayCondition
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
--now update patient stay condition
MERGE Hospital.PatientStayCondition T 
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

--ADD PATIENT STAY PROCEDURE

CREATE PROCEDURE Hospital.AddPatientStay
    --params for patient stay
        @PatientID INT,
        @AdmittanceDate DATETIME,
        @DischargeDate DATETIME,
        @Unit NVARCHAR(64),
        @RoomNumber INT,
    --params for patient stay condition
        @ConditionID INT,
    --params for patient stay doctor
        @DoctorID INT,
    --params for patient stay treatment
        @TreatmentID INT
AS
--put all data into a CTE
    WITH PatientStayDataCTE (PatientID, AdmittanceDate, DischargeDate, Unit, RoomNumber, 
                            DoctorID, TreatentID)
    AS
    (
        SELECT @PatientID, @AdmittanceDate, @DischargeDate, @Unit, @RoomNumber, @DoctorID, @TreatmentID
    )--end CTE

--update patient stay
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

--now update patient stay doctor
EXEC AddPatientStayDoctor @PatientID, @DoctorID, @AdmittanceDate, @DischargeDate;
--now update patient stay treatment
EXEC AddPatientStayTreatment @PatientID, @TreatmentID, @AdmittanceDate, @DischargeDate;
--now update patient stay condition
EXEC AddPatientStayCondition @PatientID, @ConditionID, @AdmittanceDate, @DischargeDate;

GO