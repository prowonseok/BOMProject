﻿-- 장바구니 테이블 생성 쿼리
CREATE TABLE [dbo].[Customers_Cart]
(
	[Cus_Cart_No] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Cus_No] INT NOT NULL, 
	[Cus_Cart_Cus_SaveNo] INT NOT NULL, 
    [Pro_No] INT NOT NULL, 
    [Cus_Cart_Save_EA] INT NOT NULL, 
    [Cus_Cart_Date] DATETIME NOT NULL
)

-- 장바구니 테이블 제약조건 추가
ALTER TABLE Customers_Cart ADD CONSTRAINT Cus_No_FK FOREIGN KEY (Cus_No) REFERENCES Customers(Cus_No);
ALTER TABLE Customers_Cart ADD CONSTRAINT Pro_No_FK FOREIGN KEY (Pro_No) REFERENCES Products(Pro_No);

-- 장바구니 테이블 컬럼 추가
alter table customers_cart add Cus_Cart_TotalPrice int NOT NULL DEFAULT 0

-- 자재 테이블 생성 쿼리
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

-- 자재 테이블 FK 설정
ALTER TABLE Materials ADD CONSTRAINT Mat_Type_No_FK FOREIGN KEY(Mat_Type_No) REFERENCES Materials_Type (Mat_Type_No);
ALTER TABLE Materials ADD CONSTRAINT Off_No_FK FOREIGN KEY(Off_No) REFERENCES Offerer (Off_No);

-- 고객 핸드폰, 아이디 컬럼 유니크 제약조건 추가
ALTER TABLE customers ADD CONSTRAINT Cus_Phone_Unique UNIQUE (Cus_Phone);
ALTER TABLE customers ADD CONSTRAINT Cus_ID_Unique UNIQUE(Cus_ID);

-- 저장 프로시저
-- 회원 아이디 목록 가져오기 (ID 중복검사를 위한)
CREATE PROCEDURE [dbo].[SelectAllCusID]
AS
	SELECT Cus_ID from dbo.Customers;


-- 회원 insert (회원가입)
CREATE PROCEDURE [dbo].[InsertCus]
	@id nvarchar(50),
	@name nvarchar(30),
	@phone nvarchar(15),
	@addr nvarchar(200),
	@pw nvarchar(50),
	@email nvarchar(max)
AS
	INSERT INTO dbo.Customers values (@id, @name, @phone, @addr, @pw, @email);

-- 모든 회원정보 목록 가져오기 (로그인 기능을 위한)
CREATE PROCEDURE [dbo].[SelectAllCus]
AS
	SELECT Cus_No, Cus_ID, Cus_PW, Cus_Name, Cus_Phone, Cus_Addr, Cus_Email FROM Customers;

-- 회원 정보수정
CREATE PROCEDURE [dbo].[UpdateCus]
	@no int,
	@addr nvarchar(200),
	@pw nvarchar(50),
	@email nvarchar(max),
	@phone nvarchar(15)
AS
	update Customers set Cus_Addr = @addr, Cus_PW = @pw, Cus_Email = @email, Cus_Phone = @phone
	where Cus_ID = @id;

-- 모든 상품 정보 가져오기
CREATE PROCEDURE [dbo].[SelectAllPro]
AS
	SELECT p.Pro_No, p.Mat_No, p.Pro_Price, p.Pro_Name, [pi].Pro_Img_Image
	from Products p inner join Products_Image [pi]
	on p.Pro_Img_No = [pi].Pro_Img_No;

-- 상품 (1개) 상세 정보(부품) 및 부품 분류이름 가져오기
CREATE PROCEDURE [dbo].[SelectProDetail]
	@Pro_No int
AS
	SELECT Pro_Spec FROM Products WHERE Pro_No = @Pro_No;

-- 주문 insert
CREATE PROCEDURE [dbo].[InsertSingleOrder]
	@Cus_Order_OrderNo int,
	@Cus_No int,
	@Pro_No int,
	@Cus_Order_Date datetime,
	@Cus_Order_EA int,
	@Cus_Order_Price int,
	@Emp_No int
AS
	insert into Customers_Order values(@Cus_No, @Emp_No, @Pro_No, @Cus_Order_OrderNo, @Cus_Order_Date, 1, @Cus_Order_Price, @Cus_Order_EA);

-- 주문 해당 회원 select 
CREATE PROCEDURE [dbo].[SelectOrderByCusID]
	@Cus_No int
AS
	SELECT [Cus_or].Cus_Order_No, [Cus_or].Cus_Order_OrderNo, [Cus].Cus_Name, [Pro].Pro_Name, [Cus_or].Cus_Order_Date, [Cus_or].Cus_Order_EA, [Cus_or].Cus_Order_Price, [Emp].Emp_Name, [Order_Type].Com_Type from Customers_Order [Cus_or] 
	inner join Customers [Cus] on [Cus].Cus_No = @Cus_No
	inner join Products [Pro] on [Pro].Pro_No = [Cus_or].Pro_No
	inner join Employees [Emp] on [Emp].Emp_No = [Cus_or].Emp_No
	inner join Order_CompleteType [Order_Type] on [Cus_or].Cus_OrderComplete = [Order_Type].Com_No
	where [Cus_or].Cus_No = @Cus_No
	order by [Cus_or].Cus_Order_OrderNo, [Order_Type].Com_No, [Cus_or].Cus_Order_Date

-- 장바구니 목록 선택 주문 insert
CREATE PROCEDURE [dbo].[InsertCartOrder]
	@Cus_No int,
	@Pro_No int,
	@Cus_Order_OrderNo int,
	@Cus_Order_Date datetime,
	@Cus_Order_Price int,
	@Cus_Order_EA int,
	@Emp_No int
AS
	INSERT INTO Customers_Order (Cus_No, Emp_No, Pro_No, Cus_Order_OrderNo, Cus_Order_Date,
	Cus_Order_Price, Cus_Order_EA, Cus_OrderComplete)
	values (@Cus_No, @Emp_No, @Pro_No, @Cus_Order_OrderNo,
	@Cus_Order_Date, @Cus_Order_Price, @Cus_Order_EA, 1);

-- 장바구니 목록 insert
CREATE PROCEDURE [dbo].[InsertCart]
	@cusNo int,
	@saveNo int,
	@proNo int,
	@saveEA int,
	@cartDate datetime,
	@totalPrice int
AS
	INSERT INTO Customers_Cart values (@cusNo, @saveNo, @proNo, @saveEA, @cartDate, @totalPrice);

-- 회원별 장바구니 목록 select
CREATE PROCEDURE [dbo].[SelectCart]
	@Cus_No int
AS
	SELECT [cart].Cus_Cart_No, [cart].Cus_Cart_Cus_SaveNo, [cus].Cus_Name, [pro].Pro_Name, [cart].Cus_Cart_Save_EA, [cart].Cus_Cart_TotalPrice, [cart].Cus_Cart_Date, [cart].Pro_No
	FROM Customers_Cart [cart] inner join Customers [cus]
	on [cart].Cus_No = [cus].Cus_No
	inner join Products [pro]
	on [cart].Pro_No = [pro].Pro_No
	where [cart].Cus_No = @Cus_No;

-- 회원별 장바구니 목록 delete
CREATE PROCEDURE [dbo].[DeleteCart]
	@Cus_No int,
	@cartNo int
AS
	DELETE FROM Customers_Cart where Cus_No = @Cus_No and Cus_Cart_No = @cartNo;

-- 상품 남아있는 재고 가져오기
CREATE PROCEDURE [dbo].[SelectProCount]
	@Pro_No int
AS
	SELECT [Mat].Mat_EA from Materials [Mat] inner join Products [Pro]
	on [Mat].Mat_No = [Pro].Mat_No where [Pro].Pro_No = @Pro_No

-- 고객 주문 취소
CREATE PROCEDURE [dbo].[CancelOrder]
	@Order_No int
AS
	update Customers_Order set Cus_OrderComplete = 3 where Cus_Order_No = @Order_No;

-- 장바구니 저장순서 세팅
CREATE PROCEDURE [dbo].[SetSaveNo]
	@cusNo int,
	@cartNo int
AS
With temp AS
(select Cus_Cart_No, LEAD(Cus_Cart_No, 1) OVER (order by Cus_Cart_No) AS NextCartNo from Customers_Cart)
	UPDATE Customers_Cart SET Cus_Cart_Cus_SaveNo = Cus_Cart_Cus_SaveNo - 1 WHERE Cus_No = @cusNo and Cus_Cart_No >=
	(select NextCartNo from temp where Cus_Cart_No = @cartNo)

-- 고객이 주문한 상품 이름 가져오기
CREATE PROCEDURE [dbo].[SelectBuyPro]
	@Cus_No int
AS
	SELECT DISTINCT [pro].Pro_Name, [order].Pro_No FROM Products [pro] inner join Customers_Order [order]
	on [pro].Pro_No = [order].Pro_No
	where [order].Cus_No = @Cus_No

-- 고객이 주문한 상품 번호들의 주문 번호 가져오기
CREATE PROCEDURE [dbo].[SelectBuyOrderNo]
	@Pro_No int,
	@Cus_No int
AS
BEGIN
	SELECT Cus_Order_OrderNo FROM Customers_Order [or]
	where [or].Cus_No = @Cus_No and [or].Pro_No = @Pro_No and [or].Cus_OrderComplete = 2
	and Cus_Order_OrderNo not in (select [as].Cus_Order_No from [A/S] [as] where [or].Cus_No = [as].Cus_ID)
	union
	SELECT Cus_Order_No FROM [A/S] where Cus_ID = @Cus_No and AS_EndDate is not null;
END

-- A/S 신청 (Insert)
CREATE PROCEDURE [dbo].[InsertAS]
	@Cus_ID int,
	@Cus_Order_No int,
	@Pro_No int,
	@AS_Content nvarchar(max),
	@AS_StartDate datetime,
	@Emp_No int
AS
	INSERT INTO [A/S] (Cus_ID, Cus_Order_No, Pro_No, AS_Content, AS_StartDate, Emp_No) values (@Cus_ID, @Cus_Order_No, @Pro_No, @AS_Content, @AS_StartDate, @Emp_No);

-- A/S SELECT
CREATE PROCEDURE [dbo].[SelectAllAS]
	@Cus_No int
AS
	SELECT [as].AS_No, [as].Cus_Order_No, [as].Emp_No, [as].Pro_No, [as].AS_Content, [as].AS_Price,
	[as].AS_StartDate, [as].AS_EndDate, [as].Cus_ID, [pro].Pro_Name, [cus].Cus_Name, [emp].Emp_Name
	from [A/S] [as] inner join Products [pro] on [as].Pro_No = [pro].Pro_No
	inner join Customers [cus] on  [as].Cus_ID = [cus].Cus_No
	inner join Employees [emp] on [as].Emp_No = [emp].Emp_No
	where [as].Cus_ID = @Cus_No;

-- Order_OrderNo 최대값 가져오기
CREATE PROCEDURE [dbo].[GetOrder_OrderNo_ByCus]
	@Cus_No int
AS
	SELECT max(Cus_Order_OrderNo) AS Max_Order_OrderNo from Customers_Order where Cus_No = @Cus_No;


-- STORED PROCEDURE TEST

-- SELECT
exec [SelectAllCusID];
exec [SelectAllPro];
exec [SelectAllCus];
exec [SelectProDetail];
exec [SelectOrderByCusID] 5, 1
exec [SelectCart] 5;
exec [SelectProCount] 5;
exec [SelectBuyPro] 5;
exec [SelectBuyOrderNo] 5, 5;
exec [GetOrder_OrderNo_ByCus] 5;
exec [SelectAllAS] 4;

-- INSERT
exec [InsertCus] 'testID', '테스트', '010-2525-6464', '서울특별시 금천구 가산동 448 대륭테크노타운3차', 'Qlalfqjsgh1!', 'test@naver.com';
exec [InsertSingleOrder] 1, 5, 5, '2019-02-27', 4, 50000;
exec [InsertCartOrder] 5, 5, 1, '2019-02-27', 50000, 3, 1;
exec [InsertCart] 5, 1, 5, 3, '2019-02-27', 150000;
exec [InsertAS] 5, 153, 5, 'AS신청 프로시저 테스트', '2019-02-27', 1;

-- UPDATE
exec [UpdateCus] 'testID', '주소 수정 테스트', 'Qlalfqjsgh2@', null, null
exec [CancelOrder] 153;
exec [SetSaveNo] 5, 2;

-- DELETE
exec [DeleteCart] 5, 2