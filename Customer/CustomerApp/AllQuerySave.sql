﻿-- 자재 테이블 생성 쿼리
CREATE TABLE [dbo].[Materials]
(
	[Mat_No] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Mat_Type_No] INT NOT NULL, 
    [Mat_Manufactur] NVARCHAR(50) NULL, 
    [Mat_Name] NVARCHAR(150) NOT NULL, 
    [Mat_Cost] INT NULL, 
    [Mat_Level] INT NOT NULL, 
    [Mat_EA] INT NULL, 
    [Off_No] INT NULL
)

GO

-- 거래처 테이블 생성 쿼리
CREATE TABLE [dbo].[Offerer]
(
	[Off_No] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Off_Name] NVARCHAR(100) NOT NULL, 
    [Off_Owner_Name] NVARCHAR(30) NOT NULL, 
    [Off_Owner_Phone] NVARCHAR(15) NULL, 
    [Off_Addr] NVARCHAR(200) NOT NULL, 
    [Off_Mgr_Name] NVARCHAR(30) NOT NULL, 
    [Off_Mgr_Phone] NVARCHAR(15) NOT NULL
)

GO

-- 사원 테이블 생성 쿼리
CREATE TABLE [dbo].[Employees]
(
	[Emp_No] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Emp_Name] NVARCHAR(30) NOT NULL, 
    [Emp_HireDate] DATETIME NOT NULL, 
    [Emp_Addr] NVARCHAR(200) NULL, 
    [Emp_ResidentNum] NVARCHAR(15) NOT NULL, 
    [Emp_Sex] NVARCHAR(12) NULL, 
    [Emp_Salary] INT NULL, 
    [Emp_Type] NVARCHAR(20) NOT NULL, 
    [Emp_Phone] NVARCHAR(15) NULL, 
    [Emp_Etc] NVARCHAR(MAX) NULL
)

GO
-- 자재 테이블 FK 설정
ALTER TABLE Materials ADD CONSTRAINT Mat_Type_No_FK FOREIGN KEY(Mat_Type_No) REFERENCES Materials_Type (Mat_Type_No);
ALTER TABLE Materials ADD CONSTRAINT Off_No_FK FOREIGN KEY(Off_No) REFERENCES Offerer (Off_No);


GO
-- 저장 프로시저
-- 회원 아이디 목록 가져오기 (ID 중복검사를 위한)
CREATE PROCEDURE [dbo].[SelectAllCusID]
AS
	SELECT Cus_ID from dbo.Customers;
